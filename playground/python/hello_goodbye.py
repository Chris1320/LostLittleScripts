import sys


def main() -> int:
    if len(sys.argv) == 3:
        print(f"Hello {sys.argv[1]} and {sys.argv[2]}.")
        print(f"Goodbye {sys.argv[2]} and {sys.argv[1]}.")
        return 0

    else:
        return 1


if __name__ == "__main__":
    sys.exit(main())
