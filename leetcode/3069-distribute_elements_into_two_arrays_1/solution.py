from dataclasses import dataclass


@dataclass()
class TestCase:
    nums: list[int]
    expected: list[int]


class Solution:
    def resultArray(self, nums: list[int]) -> list[int]:
        # Return the array if there's only one element.
        if len(nums) < 2:
            return nums

        arr1, arr2 = [nums[0]], [nums[1]]
        for i in range(2, len(nums)):
            arr1.append(nums[i]) if arr1[-1] > arr2[-1] else arr2.append(nums[i])

        arr1.extend(arr2)
        return arr1


def main():
    test_cases: list[TestCase] = [
        TestCase([2, 1, 3], [2, 3, 1]),
        TestCase([5, 4, 3, 8], [5, 3, 4, 8]),
        TestCase([1, 2, 14, 15], [1, 2, 14, 15]),
    ]

    success = 0
    for test_case in test_cases:
        result = Solution().resultArray(test_case.nums)
        print(f"{result} (expected: {test_case.expected} | input: {test_case.nums})")
        if result == test_case.expected:
            success += 1

    print(f"{success}/{len(test_cases)} test cases passed.")


if __name__ == "__main__":
    main()
