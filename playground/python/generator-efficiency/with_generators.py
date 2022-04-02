#!/usr/bin/env python3

# run with python3 -m cProfile with_generators.py

def numbers(x):
    for i in range(x):
        if i % 2 == 0:
            yield i


even = len(list(numbers(1000000)))

print(f"There are {even} even numbers.")
