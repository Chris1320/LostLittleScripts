#!/usr/bin/env python3

# run with python3 -m cProfile with_sets.py

def numbers(x):
    a = set(())
    for i in range(x):
        if i % 2 == 0:
            a.add(i)

    return a


even = len(list(numbers(1000000)))

print(f"There are {even} even numbers.")
