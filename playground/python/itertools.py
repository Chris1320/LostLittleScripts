#!/usr/bin/env/python3

"""
itertools

You are given a list of items, and need to
find all the possible orders of the items.

The output should be a list, containing all possible orders.

Sample Input
['a', 'b']

Sample Output
[('a', 'b'), ('b', 'a')]
"""

from itertools import permutations

items = []
while True:
    try:
        items.append(input("Enter an item; CTRL+C when done: "))

    except KeyboardInterrupt:
        break

print([i for i in permutations(items, 2)])
