#!/bin/python3

import sys
import argparse
from PIL import Image
import cv2
import os

def adjust_brightness(pinput, poutput, brightness_value):
    """Adjust the brightness of the input image and save the result to the output path."""
    # Đọc ảnh từ tệp
    img = cv2.imread(pinput)

    if img is None:
        raise ValueError("Không thể đọc ảnh. Vui lòng kiểm tra đường dẫn.")

    # Chỉnh độ sáng
    adjusted_img = cv2.convertScaleAbs(img, alpha=1, beta=brightness_value)

    # Thêm phần mở rộng mặc định nếu không có
    root, ext = os.path.splitext(poutput)
    if not ext:
        ext = '.jpg'
        poutput = root + ext

    # Lưu ảnh đã chỉnh độ sáng
    cv2.imwrite(poutput, adjusted_img)

def main():
    # Create the argument parser
    parser = argparse.ArgumentParser(description="Adjust brightness of an image.")
    
    # Add the input, brightness value, and output file arguments
    parser.add_argument('input', type=str, help='Path to the input image')
    parser.add_argument('brightness', type=int, help='Brightness value (-100 to 100)')
    parser.add_argument('output', type=str, help='Path to save the output image with adjusted brightness')

    # Parse the arguments
    args = parser.parse_args()

    # Kiểm tra điều kiện độ sáng
    if args.brightness < -100 or args.brightness > 100:
        print("Giá trị độ sáng nên nằm trong khoảng từ -100 đến 100.")
        return

    # Call the adjust brightness function with the provided arguments
    adjust_brightness(args.input, args.output, args.brightness)

if __name__ == "__main__":
    main()