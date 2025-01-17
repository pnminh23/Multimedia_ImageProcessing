#!/bin/python3

import sys
import argparse
import cv2
import os

def rotate_image(img, angle):
    """Rotate the image by the given angle."""
    # Lấy kích thước của ảnh
    (h, w) = img.shape[:2]
    
    # Tính toán điểm trung tâm của ảnh
    center = (w // 2, h // 2)
    
    # Tạo ma trận xoay
    M = cv2.getRotationMatrix2D(center, angle, 1.0)
    
    # Xoay ảnh
    rotated = cv2.warpAffine(img, M, (w, h))
    return rotated

def main():
    parser = argparse.ArgumentParser(description="Rotate an image by a specified angle.")
    
    parser.add_argument('input', type=str, help='Path to the input image')
    parser.add_argument('angle', type=float, help='Angle to rotate the image (in degrees)')
    parser.add_argument('output', type=str, help='Path to save the rotated image')

    args = parser.parse_args()

    # Đọc ảnh
    img = cv2.imread(args.input)
    if img is None:
        raise ValueError("Không thể đọc ảnh. Vui lòng kiểm tra đường dẫn.")

    # Xoay ảnh
    rotated_img = rotate_image(img, args.angle)

    root, ext = os.path.splitext(args.output)
    if not ext:
        ext = '.jpg'
        args.output = root + ext

    # Lưu ảnh đã xoay
    cv2.imwrite(args.output, rotated_img)

if __name__ == "__main__":
    main()