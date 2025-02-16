#!/usr/bin/env python3

"""
Task:  Generate a sequence of 100 random numbers
Tools: Python or Excel
Analyze:
    - Mean and variance
    - Uniformity (using histograms)
"""

# Use builtin modules as much as possible
import random
import sys
from typing import Final  # For constants

# Let's use constants to make the code more readable
Q: Final[int] = 100
# HISTOGRAM_CHAR: Final[str] = "*"
HISTOGRAM_CHAR: Final[str] = "█"  # use fancier character
MAX_VALUE: Final[int] = 20


def main() -> int:
    """Main function"""

    # Generate 100 random numbers
    random_numbers: list[int] = [random.randint(0, MAX_VALUE) for _ in range(Q)]

    # Calculate mean and variance
    mean = sum(random_numbers) / len(random_numbers)
    variance = sum((x - mean) ** 2 for x in random_numbers) / len(
        random_numbers
    )  # I just looked for its formula online cuz I forgot it

    print(f"Mean: {mean:.3f}")
    print(f"Variance: {variance:.3f}")

    # Generate histogram
    histogram: dict[int, int] = {}
    for x in random_numbers:
        if x in histogram:
            # Increment the count if the key is already in the dictionary
            histogram[x] += 1

        else:
            # Initialize the count if the key is not in the dictionary
            histogram[x] = 1

    histogram = dict(sorted(histogram.items()))

    # Print the histogram using TUI
    max_count = max(histogram.values())
    print()
    for level in range(max_count, 0, -1):
        line = " " * 8
        for x in sorted(histogram.keys()):
            if histogram[x] >= level:
                line += f"{HISTOGRAM_CHAR}    "

            else:
                line += "     "

        print(line)

    print()
    print("[K] ", " ".join(str(x).rjust(4) for x in sorted(histogram.keys())))
    print("[V] ", " ".join(str(x).rjust(4) for x in sorted(histogram.values())))

    # print(histogram)
    return 0


if __name__ == "__main__":
    sys.exit(main())
