#!/usr/bin/env python3

import sys


def main() -> int:
    try:
        sequence_length: int = int(sys.argv[1])

    except IndexError:
        sequence_length: int = int(input("How many Fibonacci numbers should be seen? > "))

    print()
    print(f"Listing {sequence_length} Fibonacci numbers...")
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
        z: int = x + y  # Calculate the next number in the sequence.
        x, y = y, z  # Move the values for the next iteration.
        print(f"[{i + 1}] {z}")
        i += 1

    return 0


if __name__ == "__main__":
    sys.exit(main())
