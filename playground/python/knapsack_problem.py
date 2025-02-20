#!/usr/bin/env python3

import sys


def knapsack(
    weight_limit: float, weights: list[float], values: list[float], i: int
) -> tuple[float, list[int]]:
    """Perform knapsack algorithm"""

    if i == 0 or weight_limit == 0:
        return 0, []

    if weights[i - 1] > weight_limit:
        return knapsack(weight_limit, weights, values, i - 1)

    else:
        value_with_item, items_with_item = knapsack(
            weight_limit - weights[i - 1], weights, values, i - 1
        )
        value_with_item += values[i - 1]
        items_with_item = items_with_item + [i - 1]

        value_without_item, items_without_item = knapsack(
            weight_limit, weights, values, i - 1
        )

        if value_with_item > value_without_item:
            return value_with_item, items_with_item
        else:
            return value_without_item, items_without_item


def main() -> int:
    """Main function"""

    weight_limit = float(input("Enter the weight limit of the knapsack: "))
    item_values: list[float] = []
    item_weights: list[float] = []

    while True:
        try:
            v = float(input(f"Enter the value of item #{len(item_values) + 1}:  "))
            w = float(input(f"Enter the weight of item #{len(item_weights) + 1}: "))
            item_values.append(v)
            item_weights.append(w)

        except ValueError:
            print("Invalid input. Please try again.")
            continue

        except KeyboardInterrupt:
            print("\nAdding...\n")
            break

    print(f"Knapsack weight limit: {weight_limit}")
    print("Items:")
    items: list[tuple[float, float]] = list(zip(item_values, item_weights))
    for i, (v, w) in enumerate(items):
        print(f"- Item #{i + 1}: Value={v}, Weight={w}")

    total_value, used_items = knapsack(
        weight_limit, item_weights, item_values, len(item_values)
    )

    print(f"\nTotal value: {total_value}")
    print("Items used:")
    for i in used_items:
        print(f"- Item #{i + 1}: Value={item_values[i]}, Weight={item_weights[i]}")

    return 0


if __name__ == "__main__":
    sys.exit(main())
