from dataclasses import dataclass


@dataclass()
class TestCase:
    nums: list[int]
    k: int
    expected: int


class Solution:
    def largestInteger(self, nums: list[int], k: int) -> int:
        occurrences: dict[int, int] = {}
        for start in range(len(nums) - k + 1):
            current_range = nums[start : start + k]
            for i in set(current_range):
                if i in occurrences:
                    occurrences[i] += 1

                else:
                    occurrences[i] = 1

        candidate = -1
        for result in occurrences.items():
            if result[1] == 1 and result[0] > candidate:
                candidate = result[0]

        return candidate


def main():
    test_cases: list[TestCase] = [
        TestCase([3, 9, 2, 1, 7], 3, 7),
        TestCase([3, 9, 7, 2, 1, 7], 4, 3),
        TestCase([0, 0], 1, -1),
        TestCase([0, 0], 2, 0),
    ]

    success = 0
    for test_case in test_cases:
        result = Solution().largestInteger(test_case.nums, test_case.k)
        print(
            f"{result} (expected: {test_case.expected}, input: {test_case.nums},{test_case.k})"
        )
        if result == test_case.expected:
            success += 1

    print(f"{success}/{len(test_cases)} test cases succeded")


if __name__ == "__main__":
    main()
