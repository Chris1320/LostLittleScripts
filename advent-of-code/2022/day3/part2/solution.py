import os
import sys


def main() -> int:
    with open(os.path.join("..", "rucksacks.txt"), 'r') as f:
        rucksacks = f.read().split('\n')  # Use this instead of readlines() to remove newlines.

    total_priorities = 0
    idx = 0
    while idx < len(rucksacks):
        if len(rucksacks[idx]) == 0:
            break

        group = []
        while len(group) < 3:
            group.append(rucksacks[idx])
            idx += 1

        total_priorities += sum(
            [
                ord(item) - 96
                if item.islower()
                else ord(item) - 38
                for item in [
                    items for items in \
                        set(group[0]) & \
                        set(group[1]) & \
                        set(group[2])
                ]
            ]
        )

    print(total_priorities)
    return 0


if __name__ == "__main__":
    sys.exit(main())
