"""
1523. Count Odd Numbers in an Interval Range

Given two non-negative integers low and high.
Return the count of odd numbers between low
and high (inclusive).

Example 1:
    Input: low = 3, high = 7
    Output: 3
    Explanation: The odd numbers between 3 and 7 are [3,5,7].

Example 2:
    Input: low = 8, high = 10
    Output: 1
    Explanation: The odd numbers between 8 and 10 are [9].

Constraints:
    0 <= low <= high <= 10^9
"""

import sys

class Solution:
    def isEven(self, x: int | float) -> bool:
        return True if x % 2 == 0 else False

    def countOdds(self, low: int, high: int) -> int:
        """
        Count the odds in an interval range.
        """

        num_in_range: int = (high + 1) - low  # Get how many numbers are in the range.

        if self.isEven(num_in_range):  # Check if num_in_range is even.
            return num_in_range // 2

        else:
            if self.isEven(low) and self.isEven(high):
                return (int(num_in_range) // 2)

            else:
                return (int(num_in_range) // 2) + 1


if __name__ == "__main__":
    try:
        num1: int = int(sys.argv[1])
        num2: int = int(sys.argv[2])

    except IndexError:
        num1: int = int(input("Num1: "))
        num2: int = int(input("Num2: "))

    count: int = Solution().countOdds(num1, num2)
    words = ("is", "number") if count == 1 else ("are", "numbers")
    print(f"There {words[0]} {count} odd {words[1]} between {num1} and {num2}.")

