class Solution:
    def average(self, salary: list[int]) -> float:
        salary.sort()  # Use Python list's built-in sort method.
        # Get the sum of the sorted list excluding the first and last element,
        # and divide it by the list length minus two to get its average.
        return sum(salary[1:len(salary) - 1]) / (len(salary) - 2)

if __name__ == "__main__":
    print("Testing...")
    tests = (
                ([1000, 2000, 3000], 2000.0),
                ([4000, 3000, 1000, 2000], 2500.0)
            )
    success = 0

    for test in tests:
        test_result: float = Solution().average(test[0])
        print(f"Input: {test[0]}")
        if test_result == test[1]:
            print(f"Output: {test_result}")
            print("Result: Passed")
            success += 1

        else:
            print(f"Output: {test_result}")
            print(f"Expected: {test[1]}")
            print("Result: Failed")

        print()

    print(f"{success} of {len(tests)} tests passed.")
