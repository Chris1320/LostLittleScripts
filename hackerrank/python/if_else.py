#!/bin/python3

"""
If-Else

Given an integer, n, perform the following conditional actions:

    - If n is odd, print `Weird`.
    - If n is even and in the inclusive range of 2 to 5, print `Not Weird`.
    - If n is even and in the inclusive range of 6 to 20, print `Weird`.
    - If n is even and greater than 20, print `Not Weird`.

Input Format:
    A single line containing a positive integer, n.

Constraints:
    1 <= n <= 100

Output Format:
    Print `Weird` if the number is weird. Otherwise, print `Not Weird`.

Sample Input:
    3

Sample Output:
    Weird

Explanation:
    n = 3
    n is odd and odd numbers are weird, so print `Weird`.
"""


def main(n):
    if n % 2 != 0:  # Odd
        print("Weird")

    else:  # Even
        if (2 <= n <= 5) or (n > 20):  # 2-5; n > 20
            print("Not Weird")

        elif 6 <= n <= 20:  # 6-20
            print("Weird")


if __name__ == '__main__':
    n = int(input().strip())
    main(n)
