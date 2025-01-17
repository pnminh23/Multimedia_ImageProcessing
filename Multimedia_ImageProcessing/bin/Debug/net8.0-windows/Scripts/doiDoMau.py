#!/bin/python3

import sys
import argparse
import cv2
import numpy as np
import os

def adjust_saturation(img, saturation_factor):
    """Adjust the saturation of the input image based on the given saturation factor."""
    # Chuyển đổi ảnh sang không gian màu HSV
    hsv = cv2.cvtColor(img, cv2.COLOR_BGR2HSV)

    # Tính toán độ bão hòa mới
    new_saturation = hsv[:, :, 1].astype(np.int16) + saturation_factor

    # Giới hạn giá trị độ bão hòa trong khoảng từ 0 đến 255
    new_saturation = np.clip(new_saturation, 0, 255)

    # Gán lại giá trị độ bão hòa
    hsv[:, :, 1] = new_saturation.astype(np.uint8)

    # Chuyển đổi lại sang không gian màu BGR
    img = cv2.cvtColor(hsv, cv2.COLOR_HSV2BGR)
    return img

def main():
    parser = argparse.ArgumentParser(description="Adjust saturation of an image.")
    
    parser.add_argument('input', type=str, help='Path to the input image')
    parser.add_argument('saturation_factor', type=int, help='Saturation adjustment factor [-255 to 255]')
    parser.add_argument('output', type=str, help='Path to save the output image with adjusted saturation')

    args = parser.parse_args()

    # Kiểm tra giá trị hệ số bão hòa
    if args.saturation_factor < -255 or args.saturation_factor > 255:
        print("Giá trị hệ số bão hòa phải nằm trong khoảng từ -255 đến 255.")
        return

    # Đọc ảnh và điều chỉnh bão hòa
    img = cv2.imread(args.input)
    if img is None:
        raise ValueError("Không thể đọc ảnh. Vui lòng kiểm tra đường dẫn.")

    img = adjust_saturation(img, args.saturation_factor)

    root, ext = os.path.splitext(args.output)
    if not ext:
        ext = '.jpg'
        args.output = root + ext

    cv2.imwrite(args.output, img)

if __name__ == "__main__":
    main()