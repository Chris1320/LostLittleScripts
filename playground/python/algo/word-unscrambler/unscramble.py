import argparse
import itertools
import sys
import time

from colorama import Fore as col_f
from colorama import Style as col_s


def verbose_print(verbose: bool, message: str, end: str = "\n") -> None:
    print(f"{message}{end}" if verbose else "", end="")


def word_unscrambler(
    verbose: bool, scrambled_word: str, dictionary: set[str]
) -> list[str]:
    """
    Unscrambles a scrambled word using a bruteforce algorithm.

    Args:
        scrambled_word: The scrambled word.
        dictionary: A set or list of valid words.

    Returns:
        A list of unscrambled words found in the dictionary.
    """

    scrambled_word = scrambled_word.lower()  # For case-insensitive matching
    possible_words: list[str] = []  # Store possible words to let user choose from

    for permutation in itertools.permutations(scrambled_word):
        word = "".join(permutation)
        if len(dictionary) == 0:
            possible_words.append(word)
            continue

        if word in dictionary:
            if word not in possible_words:
                verbose_print(verbose, f"Found word: {word}")
                possible_words.append(word)

    return possible_words


def main() -> int:
    # Parse command-line arguments
    parser = argparse.ArgumentParser(
        description="Unscramble a given scrambled word using a dictionary of valid words."
    )
    _ = parser.add_argument(
        "sentence", type=str, help="The scrambled word or sentence to unscramble."
    )
    _ = parser.add_argument(
        "-d",
        "--dictionary",
        type=argparse.FileType("r"),
        help="Path to the file containing valid words, one per line.",
    )
    _ = parser.add_argument(
        "-v", "--verbose", action="store_true", help="Print verbose output."
    )

    args = parser.parse_args()

    verbose: bool = args.verbose  # pyright: ignore [reportAny]
    dictionary: set[str] = set()
    if args.dictionary is None:  # pyright: ignore [reportAny]
        print("[!] No dictionary provided. Will print all possible permutations.")

    else:
        verbose_print(verbose, "[*] Reading dictionary...")
        time_dict_read_start = time.time()
        dictionary = set(
            word.strip().lower()  # pyright: ignore [reportAny]
            for word in args.dictionary  # pyright: ignore [reportAny]
        )
        time_dict_read_end = time.time()
        verbose_print(
            verbose,
            "[*] Loaded {d} words. (Took {col}{t}{res}s)".format(
                d=len(dictionary),
                col=col_f.LIGHTCYAN_EX,
                t=round(time_dict_read_end - time_dict_read_start, 2),
                res=col_s.RESET_ALL,
            ),
        )

    sentence: str = "".join(
        c
        for c in args.sentence  # pyright: ignore [reportAny]
        if c.isalpha() or c.isspace()  # pyright: ignore [reportAny]
    )
    possible_results: list[list[str]] = []

    print(f"\n[*] Unscrambling sentence/word:\n{sentence}\n")
    time_unscramble_start = time.time()
    for word in sentence.split():
        possible_results.append(word_unscrambler(verbose, word, dictionary))
    time_unscramble_end = time.time()

    print(
        "[*] Unscrambled in {col}{time}{res}s".format(
            col=col_f.LIGHTCYAN_EX,
            time=round(time_unscramble_end - time_unscramble_start, 2),
            res=col_s.RESET_ALL,
        )
    )

    if verbose:
        print("[*] Possible words:")
        for idx, word in enumerate(sentence.split()):
            print(
                f"- {word} [{len(possible_results[idx])}]: {', '.join(possible_results[idx])}"
            )

    print()

    correct_words = [0 for _ in range(len(possible_results))]
    for word_idx in range(len(possible_results)):
        if len(possible_results[word_idx]) == 1:
            correct_words[word_idx] = 0
            continue

        # Loop until user confirms the correct word
        loop: bool = True
        if len(possible_results[word_idx]) == 0:
            continue  # Skip if no possible words found

        while loop:
            for pword_idx in range(len(possible_results[word_idx])):
                s = ""
                for i in range(len(possible_results)):
                    # Highlight the current word being manually verified
                    try:
                        s += (
                            f"{col_f.LIGHTYELLOW_EX}{possible_results[i][pword_idx]}{col_s.RESET_ALL} "
                            if i == word_idx
                            else f"{possible_results[i][correct_words[i]]} "
                        )

                    except IndexError:
                        s += f"{col_f.LIGHTRED_EX}{sentence.split()[i]}{col_s.RESET_ALL} "

                print()
                print(s)
                try:
                    if (
                        input(
                            f"Is the {col_f.LIGHTYELLOW_EX}highlighted{col_s.RESET_ALL} word correct? (y/N) >>> "
                        ).lower()
                        == "y"
                    ):
                        correct_words[word_idx] = pword_idx
                        loop = False
                        break

                except KeyboardInterrupt:
                    print("\n[!] Exiting...")
                    return 2

    print(
        "\n[*] Unscrambled sentence:\n{col}{sentence}{res}".format(
            sentence=" ".join(
                (
                    possible_results[i][correct_words[i]]
                    if len(possible_results[i]) > 0
                    else sentence.split()[i]
                )
                for i in range(len(possible_results))
            ),
            col=col_f.LIGHTGREEN_EX,
            res=col_s.RESET_ALL,
        )
    )

    print()
    return 0


if __name__ == "__main__":
    sys.exit(main())
