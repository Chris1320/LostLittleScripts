import os
import sys


def main() -> int:
    with open(os.path.join("..", "list.txt"), 'r') as f:
        list = f.read().split('\n')

    duplicates = 0
    for pairs in list:
        pairs = pairs.split(',')
        pair1 = pairs[0].partition('-')
        pair2 = pairs[1].partition('-')
        pair1_contents = [i for i in range(int(pair1[0]), int(pair1[2]) + 1)]
        pair2_contents = [i for i in range(int(pair2[0]), int(pair2[2]) + 1)]
        minimum_length = min((min(pair1_contents), min(pair2_contents)))
        maximum_length = max((max(pair1_contents), max(pair2_contents)))

        # The following is for visualization purposes only. It can be removed without any consequences.
        output = ["", ""]
        for idx in range(minimum_length, maximum_length + 1):
            output[0] += str(idx) if idx in pair1_contents else '.'
            output[1] += str(idx) if idx in pair2_contents else '.'

        print(output[0])
        print(output[1])
        # print(pair1_contents)
        # print(pair2_contents)
        print('=' * 40)

        # Evaluate if the start and end of each pair is in each pairs' contents.
        if (
            int(pair1[0]) in pair2_contents and int(pair1[2]) in pair2_contents
        ) or (int(pair2[0]) in pair1_contents and int(pair2[2]) in pair1_contents):
            duplicates += 1

    print()
    print(duplicates)
    return 0


if __name__ == "__main__":
    sys.exit(main())
