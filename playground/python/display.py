#!/usr/bin/env python3

"""
Activity 12 - Display to Python using Looping and Conditional Statements

Activity 12.1:
    Create a box of rectangle of 5 x 7 without inputting any number and
    using conditional and looping statements only.
Activity 12.2:
    Create a box of square of 7 x 7 without inputting any number and
    using conditional and looping statements only.
Activity 12.3:
    Create a diamond without inputting any number and using conditional
    and looping statements only.
"""

# disable static type checking for this file
# since this is just for a school activity
# pyright: reportAny=false

import argparse
from time import sleep

DELAY = 0.1


def activity_12_1(c: str, simulate: bool = False) -> None:
    """Create a box of rectangle of 5 x 7 without inputting any number and
    using conditional and looping statements only.

    Args:
        c: The character to use for display.
        simulate: A boolean flag to visualize the steps of the simulation.
    """

    print("Activity 12.1")
    print()
    x, y = 5, 7
    for _ in range(x):
        for _ in range(y):
            print(c, end="", flush=True)
            if simulate:
                sleep(DELAY)

        print()


def activity_12_2(c: str, s: str, simulate: bool) -> None:
    """Create a box of square of 7 x 7 without inputting any number and
    using conditional and looping statements only.

    Args:
        c: The character to use for display.
        s: The space character to use for display.
        simulate: A boolean flag to visualize the steps of the simulation.
    """

    print("Activity 12.2")
    print()
    x, y = 7, 7
    for i in range(x):
        for j in range(y):
            print(c if i in {0, x - 1} or j in {0, y - 1} else s, end="", flush=True)
            if simulate:
                sleep(DELAY)

        print()


def activity_12_3(c: str, s: str, simulate: bool) -> None:
    """Create a diamond without inputting any number and using conditional
    and looping statements only.

    Args:
        c: The character to use for display.
        s: The space character to use for display.
        simulate: A boolean flag to visualize the steps of the simulation.
    """

    print("Activity 12.3")
    print()
    y = 11
    for i in range(y):
        for j in range(y):
            if simulate:
                sleep(DELAY)
            print(
                c if i + j in {5, 15} or 5 in {j - i, i - j} else s, end="", flush=True
            )

        print()


def main(arg: str | None, c: str, s: str, simulate: bool) -> None:
    """Allows the user to select which activity to run.

    Args:
        act: An optional string representing the activity number to run.
        c: The character to use for display.
        s: The space character to use for display.
        simulate: A boolean flag to visualize the steps of the simulation.
    """

    while True:
        if arg is None:
            print("[1] Activity 12.1")
            print("[2] Activity 12.2")
            print("[3] Activity 12.3")
            print("[Q] Quit")
            act = input("\nSelect activity number: ")

        else:
            act = arg

        match act:
            case act if act.lower() == "q":
                print("Exiting program.")
                break

            case "1":
                activity_12_1(c, simulate)

            case "2":
                activity_12_2(c, s, simulate)

            case "3":
                activity_12_3(c, s, simulate)

            case _:
                print("Invalid activity number.")

        # do not loop if a command-line argument was passed
        if arg is not None:
            break


if __name__ == "__main__":
    # main(sys.argv[1] if len(sys.argv) > 1 else None)
    parser = argparse.ArgumentParser()
    _ = parser.add_argument("act", nargs="?", help="Activity number to run")
    _ = parser.add_argument("-c", "--char", help="Character to use for display")
    _ = parser.add_argument("-s", "--space", help="Space character to use for display")
    _ = parser.add_argument(
        "--simulate",
        action="store_true",
        default=False,
        help="Visualize the steps of the simulation",
    )
    args = parser.parse_args()

    main(
        args.act if args.act else None,
        args.char if args.char else "*",
        args.space if args.space else " ",
        simulate=args.simulate,
    )
