#!/usr/bin/env python3

import sys
import time


def main() -> int:
    try:
        target_month: int = int(sys.argv[1])

    except IndexError:
        target_month: int = int(input("How many months to run the simulation? > "))

    if target_month < 1:
        print("[ERROR] Negative numbers are not allowed.")
        return 1

    previous_generation_pairs: list[int] = [0, 1]  # The two previous generations.
    pairs_of_rabbits: int = 1  # The starting pairs of rabbits.
    generation: int = 1  # The current generation.
    sleep_length: int = 1

    print(f"Generation 0: There are {pairs_of_rabbits} starting pair(s) of rabbits.")
    time.sleep(sleep_length)
    while generation < target_month:
        print(f"Generation {generation}: There are now {pairs_of_rabbits} pair(s) of rabbits.")
        previous_generation_pairs[0] = previous_generation_pairs[1]
        previous_generation_pairs[1] = pairs_of_rabbits
        pairs_of_rabbits = previous_generation_pairs[0] + previous_generation_pairs[1]
        generation += 1
        time.sleep(sleep_length)

    return 0


if __name__ == "__main__":
    sys.exit(main())
