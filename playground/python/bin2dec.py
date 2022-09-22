#!/usr/bin/env python3

import sys


def bin2dec(binary: str) -> int:
    """
    Convert binary to decimal.

    :param str binary: The binary number to convert.

    :returns int: The decimal form of <binary>.
    """

    place_value: int = 1  # The place value of the first binary digit.
    result: int = 0
    for num in binary[::-1]:  # Start from the right side of the binary number.
        if num in {'0', '1'}:  # Check if the number is binary.
            if int(num) == 1:
                result += int(place_value)

            place_value = place_value * 2  # Get the next place value of the next digit.

        elif num == ' ':
            continue

        else:
            raise ValueError("Invalid binary number.")

    return result


def main() -> int:
    """
    The main function of bin2dec.py
    """

    try:
        bin_num: str = sys.argv[1]

    except IndexError:
        bin_num: str = input("Enter binary number to convert: ")

    try:
        print(f"The decimal form of the binary number `{bin_num}` is `{bin2dec(bin_num)}`.")

    except ValueError as e:
        print(e)

    return 0


if __name__ == "__main__":
    sys.exit(main())
