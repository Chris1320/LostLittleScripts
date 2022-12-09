import os
import sys

import colorama  # For visualization of the grid map


class TreeHeightChecker:
    def __init__(self, data: list[str]) -> None:
        self.coordinates: list[list[int]] = []  # Format: self.coordinates[y][x]
        for line in data:
            self.coordinates.append([int(x) for x in line])

    def isVisibleFromLineOfSight(self, x: int, y: int) -> bool:
        """
        Return if the tree in the coordinate is visible.
        """

        tree_height = self.coordinates[y][x]
        is_visible = []

        # Check from top to <y>
        is_visible.append(all([
            True
            if self.coordinates[top_y][x] < tree_height
            else False
            for top_y in range(0, y)
        ]))

        # Check from <y + 1> to bottom
        is_visible.append(all([
            True
            if self.coordinates[bottom_y][x] < tree_height
            else False
            for bottom_y in range(y + 1, len(self.coordinates))
        ]))

        # Check from left to <x>
        is_visible.append(all([
            True
            if self.coordinates[y][left_x] < tree_height
            else False
            for left_x in range(0, x)
        ]))

        # Check from <x + 1> to right
        is_visible.append(all([
            True
            if self.coordinates[y][right_x] < tree_height
            else False
            for right_x in range(x + 1, len(self.coordinates[y]))
        ]))

        # You can safely remove the following code if you don't need the logs.
        # EXCEPT FOR THE RETURN STATEMENT OF COURSE!

        result = f"{tree_height} at ({x}, {y}) "
        visible_views = []

        visible_views.append("top") if is_visible[0] else None
        visible_views.append("bottom") if is_visible[1] else None
        visible_views.append("left") if is_visible[2] else None
        visible_views.append("right") if is_visible[3] else None

        result += ("is visible from the " + ", ".join(visible_views)) \
            if len(visible_views) != 0 \
            else "is not visible from any direction."

        print(result)
        return any(is_visible)


def strVisible(m) -> str:
    return f"{colorama.Style.BRIGHT}{colorama.Fore.GREEN}{m}{colorama.Style.RESET_ALL}"


def strInvisible(m) -> str:
    return f"{colorama.Style.DIM}{colorama.Fore.GREEN}{m}{colorama.Style.RESET_ALL}"


def strVisibleEdge(m) -> str:
    return f"{colorama.Style.DIM}{colorama.Fore.WHITE}{m}{colorama.Style.RESET_ALL}"


def main() -> int:
    print("Reading data...")
    with open(os.path.join("..", "coords.txt"), 'r') as f:
        # ? Read the data and convert it into a 2D array.
        checker = TreeHeightChecker(f.read().split('\n'))

    visible_trees = 0  # This is the actual answer needed.
    visualization: list[str] = []  # Used for visualization only
    print("Calculating...\n")
    for y in range(0, len(checker.coordinates)):  # Use 1-len(c)-1 instead of 0-len(c) to omit outer trees.
        line = []
        for x in range(0, len(checker.coordinates[y])):
            tree_height_in_coord = checker.coordinates[y][x]
            if x in {0, len(checker.coordinates) - 1} or y in {0, len(checker.coordinates) - 1}:
                # Check if the coordinate is in the edge of the plane.
                line.append(strVisibleEdge(tree_height_in_coord))
                visible_trees += 1
                continue

            if checker.isVisibleFromLineOfSight(x, y):
                line.append(strVisible(tree_height_in_coord))
                visible_trees += 1

            else:
                line.append(strInvisible(tree_height_in_coord))

        visualization.append(''.join([i for i in line]))

    print("\nCalculating... Done!\n")
    for line in visualization:  # Print the visualized grid map.
        print(line)

    print(f"\nThere are {visible_trees} visible trees in the grid map.")

    return 0


if __name__ == "__main__":
    sys.exit(main())
