#!/bin/python3

import sys
import argparse
import cv2
import numpy as np
import os

def get_color(name):
    """Return a BGR color tuple based on the color name."""
    colors = {
        'black': (0, 0, 0),
        'white': (255, 255, 255),
        'red': (0, 0, 255),
        'green': (0, 255, 0),
        'blue': (255, 0, 0),
        'yellow': (0, 255, 255),
        'cyan': (255, 255, 0),
        'magenta': (255, 0, 255),
    }
    return colors.get(name.lower(), None)

def add_border(img, border_size, color):
    """Add a border to the image."""
    return cv2.copyMakeBorder(img, border_size, border_size, border_size, border_size, cv2.BORDER_CONSTANT, value=color)

def main():
    parser = argparse.ArgumentParser(description="Add a border to an image.")
    
    parser.add_argument('input', type=str, help='Path to the input image')
    parser.add_argument('border_size', type=int, help='Size of the border in pixels')
    parser.add_argument('color', type=str, help='Color name for the border (e.g., black, white, red, etc.)')
    parser.add_argument('output', type=str, help='Path to save the image with border')

    args = parser.parse_args()

    # Đọc ảnh
    img = cv2.imread(args.input)
    if img is None:
        raise ValueError("Không thể đọc ảnh. Vui lòng kiểm tra đường dẫn.")

    # Lấy màu từ tên màu
    color = get_color(args.color)
    if color is None:
        raise ValueError("Tên màu không hợp lệ. Vui lòng sử dụng một trong các màu: black, white, red, green, blue, yellow, cyan, magenta.")

    # Thêm khung cho ảnh
    bordered_img = add_border(img, args.border_size, color)

    root, ext = os.path.splitext(args.output)
    if not ext:
        ext = '.jpg'
        args.output = root + ext

    # Lưu ảnh đã thêm khung
    cv2.imwrite(args.output, bordered_img)

if __name__ == "__main__":
    main()