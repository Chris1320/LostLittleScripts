#!/usr/bin/env python3

import sys
import math


def getSuffix(n: int) -> str:
    """
    Get the suffix of <n>.

    :returns str: The suffix of <n>.
    """

    if str(n)[-1] == "1" and n != 11:
        return "st"

    elif str(n)[-1] == "2" and n != 12:
        return "nd"

    elif str(n)[-1] == "3" and n != 13:
        return "rd"

    else:
        return "th"


def getFibonacciNumber(n: int) -> float:
    """
    Get the nth term of the Fibonacci number.

    :returns int: The nth term of the Fibonacci number.
    """

    # Use the Binet's formula for finding the nth term of the Fibonacci number.
    # (1/√5) * (((1+√5)/2)^n)-(((1-√5)/2)^n)

    return int(
        round(
            (1 / math.sqrt(5)) * (
                (
                    ((1 + math.sqrt(5)) / 2) ** n
                ) - (
                    ((1 - math.sqrt(5)) / 2) ** n
                )
            ),
            0
        )
    )


def main():
    try:
        n: int = int(sys.argv[1])  # Check if user entered a command-line argument.

    except IndexError:
        n: int = int(input("Enter the nth term of the Fibonacci number to get > "))

    print(f"The {n}{getSuffix(n)} term of the Fibonacci sequence is {getFibonacciNumber(n)}.")


if __name__ == "__main__":
    sys.exit(main())
