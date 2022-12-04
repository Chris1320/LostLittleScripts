import os
import sys


def main() -> int:
    with open(os.path.join("..", "list.txt"), 'r') as f:
        contents = f.read().split('\n')

    duplicates = 0
    for pairs in contents:
        pair1 = list(map(int, pairs.split(',')[0].split('-')))  # use split instead of partition to remove separator in one line
        pair2 = list(map(int, pairs.split(',')[1].split('-')))
        pair1_contents = [i for i in range(pair1[0], pair1[1] + 1)]
        pair2_contents = [i for i in range(pair2[0], pair2[1] + 1)]

        # Evaluate if the start and end of each pair is in each pairs' contents.
        if len(set(pair1_contents) & set(pair2_contents)) > 0:
            duplicates += 1

    print()
    print(duplicates)
    return 0


if __name__ == "__main__":
    sys.exit(main())
