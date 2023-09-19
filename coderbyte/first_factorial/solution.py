#!/usr/bin/env python3

import sys


def first_factorial(n: int, total: int = 1) -> int:
    """
    Get the first factorial of the number.

    :param int n: The current number to process.
    :param int total: The current total.
    :return int: The result.
    """

    if n > 0:
        return first_factorial(n - 1, n * total)

    return total


def main() -> int:
    """
    The main function of the program.

    :return int: The exit code.
    """

    print(first_factorial(int(input("Enter a number: "))))

    return 0


if __name__ == "__main__":
    sys.exit(main())
