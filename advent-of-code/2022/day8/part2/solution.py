import os
import sys

import colorama  # For visualization of the grid map


class TreeHeightChecker:
    def __init__(self, data: list[str]) -> None:
        self.coordinates: list[list[int]] = []  # Format: self.coordinates[y][x]
        for line in data:
            self.coordinates.append([int(x) for x in line])

    def getScenicScore(self, x: int, y: int) -> int:
        """
        Get the scenic score of the tree in the designated coordinate.
        """

        tree_height = self.coordinates[y][x]
        top_scenic_score = 0
        bottom_scenic_score = 0
        left_scenic_score = 0
        right_scenic_score = 0

        # Check from <y> to top
        for top_y in range(y - 1, -1, -1):
            top_scenic_score += 1
            if self.coordinates[top_y][x] >= tree_height:
                break

        # Check from <y + 1> to bottom
        for bottom_y in range(y + 1, len(self.coordinates)):
            bottom_scenic_score += 1
            if self.coordinates[bottom_y][x] >= tree_height:
                break

        # Check from <x> to left
        for left_x in range(x - 1, -1, -1):
            left_scenic_score += 1
            if self.coordinates[y][left_x] >= tree_height:
                break

        # Check from <x + 1> to right
        for right_x in range(x + 1, len(self.coordinates[y])):
            right_scenic_score += 1
            if self.coordinates[y][right_x] >= tree_height:
                break

        return top_scenic_score * bottom_scenic_score * left_scenic_score * right_scenic_score

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

        return any(is_visible)


def strVisible(m) -> str:
    return f"{colorama.Style.NORMAL}{colorama.Fore.GREEN}{m}{colorama.Style.RESET_ALL}"


def strInvisible(m) -> str:
    return f"{colorama.Style.DIM}{colorama.Fore.GREEN}{m}{colorama.Style.RESET_ALL}"


def strVisibleEdge(m) -> str:
    return f"{colorama.Style.DIM}{colorama.Fore.WHITE}{m}{colorama.Style.RESET_ALL}"


def strNewCandidate(m) -> str:
    return f"{colorama.Style.BRIGHT}{colorama.Fore.YELLOW}{m}{colorama.Style.RESET_ALL}"


def main() -> int:
    print("Reading data...")
    with open(os.path.join("..", "coords.txt"), 'r') as f:
        # ? Read the data and convert it into a 2D array.
        checker = TreeHeightChecker(f.read().split('\n'))

    candidate_score = 0
    candidate_height = 0
    candidate_coords: tuple[int, int] = (0, 0)
    visualization: list[str] = []  # Used for visualization only
    print("Calculating...\n")
    for y in range(0, len(checker.coordinates)):  # Use 1-len(c)-1 instead of 0-len(c) to omit outer trees.
        line = []
        for x in range(0, len(checker.coordinates[y])):
            tree_height_in_coord = checker.coordinates[y][x]
            if x in {0, len(checker.coordinates) - 1} or y in {0, len(checker.coordinates) - 1}:
                # Check if the coordinate is in the edge of the plane.
                line.append(strVisibleEdge(tree_height_in_coord))
                continue

            if checker.isVisibleFromLineOfSight(x, y):  # NOTE: I'm keeping the code from part 1 just to make the visualization.
                possible_candidate_score = checker.getScenicScore(x, y)
                if possible_candidate_score >= candidate_score:
                    candidate_score = possible_candidate_score
                    candidate_coords = (x, y)
                    candidate_height = checker.coordinates[y][x]
                    line.append(strNewCandidate(tree_height_in_coord))

                else:
                    line.append(strVisible(tree_height_in_coord))

            else:
                line.append(strInvisible(tree_height_in_coord))

        visualization.append(''.join([i for i in line]))

    for line in visualization:  # Print the visualized grid map.
        print(line)

    print("\n{0} {1}".format(
        f"Among all visible trees, the tree with height {candidate_height} located in",
        f"grid {candidate_coords} has the highest scenic score, {candidate_score}."
    ))

    return 0


if __name__ == "__main__":
    sys.exit(main())
