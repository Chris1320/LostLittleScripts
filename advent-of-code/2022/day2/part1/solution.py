import os
import sys


def evaluate(p1: int, p2: int) -> int:
    """
    1 if player 1 wins, 2 if player 2 wins.
    0 if tied.
    """

    # 1 = rock
    # 2 = paper
    # 3 = scissors

    if p1 == p2:
        return 0

    return p1 % 3 == p2 - 1


def getWeapon(char: str) -> int:
    return 1 if char in {'A', 'X'} \
        else 2 if char in {'B', 'Y'} \
        else 3  # Returned if char in {'C', 'Z'}


def main() -> int:
    total_score = 0

    with open(os.path.join("..", "game_outcomes.txt"), 'r') as f:
        games = f.readlines()

    for game in games:
        game = game.rstrip().split(' ')
        enemy_choice = getWeapon(game[0])
        my_choice = getWeapon(game[1])

        if my_choice == enemy_choice:
            total_score += my_choice + 3
            print(f"Tied. {total_score=}")

        elif enemy_choice % 3 == my_choice - 1:
            total_score += my_choice + 6
            print(f"Won.  {total_score=}")

        else:
            total_score += my_choice
            print(f"Lost. {total_score=}")

    return 0


if __name__ == "__main__":
    sys.exit(main())
