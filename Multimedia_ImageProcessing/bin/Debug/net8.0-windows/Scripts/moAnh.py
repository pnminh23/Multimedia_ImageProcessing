#!/bin/python3

import sys
import argparse
from PIL import Image
import cv2
import os

def adjust_blur(pinput, poutput, blur_factor):
    """Adjust the blur of the input image and save the result to the output path."""
    # Đọc ảnh từ tệp
    img = cv2.imread(pinput)

    if img is None:
        raise ValueError("Không thể đọc ảnh. Vui lòng kiểm tra đường dẫn.")

    # Chỉnh độ mờ
    adjusted_img = cv2.GaussianBlur(img, (blur_factor, blur_factor), 0)

    # Thêm phần mở rộng mặc định nếu không có
    root, ext = os.path.splitext(poutput)
    if not ext:
        ext = '.jpg'
        poutput = root + ext

    # Lưu ảnh đã chỉnh độ mờ
    cv2.imwrite(poutput, adjusted_img)

def main():
    # Create the argument parser
    parser = argparse.ArgumentParser(description="Adjust blur of an image.")
    
    # Add the input, blur factor, and output file arguments
    parser.add_argument('input', type=str, help='Path to the input image')
    parser.add_argument('blur_factor', type=int, help='Blur factor (must be odd and between 3 and 31)')
    parser.add_argument('output', type=str, help='Path to save the output image with adjusted blur')

    # Parse the arguments
    args = parser.parse_args()

    # Kiểm tra điều kiện độ mờ dk gốc là >=3 và <=31
    if args.blur_factor < 1 or args.blur_factor > 31 or args.blur_factor % 2 == 0:
        print("Giá trị độ mờ phải là số lẻ trong khoảng từ 3 đến 31.")
        return

    # Call the adjust blur function with the provided arguments
    adjust_blur(args.input, args.output, args.blur_factor)

if __name__ == "__main__":
    main()