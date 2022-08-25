#!/usr/bin/env python3

import sys


def main() -> int:
    sequence_length: int = int(input("How many Fibonacci numbers' quotients should we list? > "))
    print()
    print(f"Listing {sequence_length} quotients of Fibonacci numbers...")
    print()

    i: int = 2
    x: int = 1
    y: int = 1
    current_quotient: float = 0.0
    previous_quotient: float = 0.0

    if sequence_length < 1:
        return 0

    print(f"[1] {x}")
    if sequence_length < 2:
        return 0

    print(f"[2] {y} ({(y / x):.8f})")
    while i < sequence_length:
        z: int = x + y
        x, y = y, z  # Move z to y, and y to x. Overwrite previous value of x.
        previous_quotient = current_quotient
        current_quotient = round(y / x, 8)
        quotient_differences = round(abs(current_quotient - previous_quotient), 6)
        print(f"[{i + 1}] {z} ({current_quotient}) [{quotient_differences} difference]")
        i += 1

    return 0


if __name__ == "__main__":
    sys.exit(main())
