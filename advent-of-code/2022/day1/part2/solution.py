#!/usr/bin/env python3

import os
import sys


def main() -> int:
    inventories: list[int] = []
    with open(os.path.join("..", "list.txt"), 'r') as f:
        for inventory in f.read().split('\n\n'):
            inventories.append(sum([int(i) for i in inventory.split('\n') if i.isdigit()]))

    inventories.sort()
    print(sum(inventories[-3:]))
    return 0


if __name__ == "__main__":
    sys.exit(main())
