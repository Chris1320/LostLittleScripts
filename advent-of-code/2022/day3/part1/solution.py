import os
import sys


def main() -> int:
    with open(os.path.join("..", "rucksacks.txt"), 'r') as f:
        rucksacks = f.read().split('\n')  # Use this instead of readlines() to remove newlines.

    total_priorities = 0
    for rucksack in rucksacks:
        if len(rucksack) == 0:
            continue

        container_length = round(len(rucksack) / 2)
        container1 = rucksack[:container_length]
        container2 = rucksack[container_length:]
        total_priorities += sum(
            [
                ord(item) - 96
                if item.islower()
                else ord(item) - 38
                for item in [
                    items for items in set(container1) & set(container2)
                ]
            ])

    print(total_priorities)
    return 0


if __name__ == "__main__":
    sys.exit(main())
