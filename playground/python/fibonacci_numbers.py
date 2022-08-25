#!/usr/bin/env python3

import sys


def nextFibonacciNumber(x: int, y: int):
    return x + y


def main() -> int:
    sequence_length: int = int(input("How many fibonacci numbers should be seen? > "))
    print()
    print(f"Listing {sequence_length} fibonacci numbers...")
    print()
    i: int = 2  # This is already two because the first two numbers in the sequence is defined below.
    x: int = 1  # These are the starting values of the Fibonacci sequence.
    y: int = 1

    if sequence_length < 1:
        return 0

    print(f"[1] {x}")
    if sequence_length < 2:
        return 0

    print(f"[2] {y}")
    while i < sequence_length:
        z: int = nextFibonacciNumber(x, y)
        x, y = y, z  # Move the values.
        print(f"[{i + 1}] {z}")
        i += 1

    return 0


if __name__ == "__main__":
    sys.exit(main())
