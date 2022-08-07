#!/usr/bin/env python3

"""
Make a program for one of our most prestigious and revered Python trainers, Robin Hood.
The program should be capable of calculating the values of x (roots) given a, b and c
following the general equation as follows.

The program first asks the user to enter his name and his trainer ID. 

Then the entered ID and name then shall be verified to be #6759 and “Robin Hood” in order
for the program to proceed, otherwise, the program exits.

Once verified, the program asks for values of a, b and c and later calculates x by using
the formula:

    x = (-b±√b²-4ac)/2a

source: How to Train Your Python (book)
"""

import math


def calculate(a: int, b: int, c: int) -> tuple[float, float]:
    x = math.sqrt((b ** 2) - (4 * a * c))  # Re-use inner equation.
    y = (-b + x) / (2 * a)  # Get first equation.
    z = (-b - x) / (2 * a)  # Get next equation.

    return (y, z)


def main() -> int:
    name: str = input("Enter your name: ")
    id: int = int(input("Enter your trainer ID: "))

    if name.lower() != "robin hood":
        print("Incorrect name.")
        return 1

    if id != 6759:
        print("Invalid trainer ID.")
        return 2

    a: int = int(input("Enter a: "))
    b: int = int(input("Enter b: "))
    c: int = int(input("Enter c: "))

    x = calculate(a, b, c)
    print(f"The answer to the equation is {x[0]} and {x[1]}.")
    return 0


if __name__ == "__main__":
    exit(main())
