#!/bin/python3

import sys
import argparse
import cv2
import numpy as np
import os

def resize_image(image, scale=0.5):
    """Giảm kích thước ảnh xuống theo tỷ lệ cho trước."""
    return cv2.resize(image, (0, 0), fx=scale, fy=scale)

def merge_images(image1, image2, merge_type):
    """Ghép hai ảnh theo kiểu được chỉ định."""
    # Resize ảnh xuống 50%
    image1 = resize_image(image1)
    image2 = resize_image(image2)

    # Điều chỉnh kích thước ảnh thứ hai theo kích thước ảnh lớn hơn
    if merge_type in ['a1da2', 'a2da1']:
        # Ghép dọc
        max_width = max(image1.shape[1], image2.shape[1])
        image1 = cv2.resize(image1, (max_width, int(image1.shape[0] * (max_width / image1.shape[1]))))
        image2 = cv2.resize(image2, (max_width, int(image2.shape[0] * (max_width / image2.shape[1]))))
        merged = np.vstack((image1, image2)) if merge_type == 'a1da2' else np.vstack((image2, image1))
    else:
        # Ghép ngang
        max_height = max(image1.shape[0], image2.shape[0])
        image1 = cv2.resize(image1, (int(image1.shape[1] * (max_height / image1.shape[0])), max_height))
        image2 = cv2.resize(image2, (int(image2.shape[1] * (max_height / image2.shape[0])), max_height))
        merged = np.hstack((image1, image2)) if merge_type == 'a1ta2' else np.hstack((image2, image1))

    return merged

def main():
    parser = argparse.ArgumentParser(description="Merge two images.")
    
    parser.add_argument('input1', type=str, help='Path to the first input image')
    parser.add_argument('input2', type=str, help='Path to the second input image')
    parser.add_argument('type', type=str, help='Merge type (e.g., a1da2, a2da1, a1ta2, a2ta1)')
    parser.add_argument('output', type=str, help='Path to save the merged image')

    args = parser.parse_args()

    # Đọc ảnh
    img1 = cv2.imread(args.input1)
    img2 = cv2.imread(args.input2)

    if img1 is None or img2 is None:
        raise ValueError("Không thể đọc một trong các ảnh. Vui lòng kiểm tra đường dẫn.")

    # Ghép ảnh
    merged_image = merge_images(img1, img2, args.type)

    # Lưu ảnh đã ghép
    cv2.imwrite(args.output, merged_image)

if __name__ == "__main__":
    main()