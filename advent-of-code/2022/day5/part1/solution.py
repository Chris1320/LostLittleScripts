import os
import sys


class Crane:
    def __init__(self, stacks: list[list[str]], operations: list[tuple[int, int, int]]):
        """
        Re-arrange the stacks according to the list of operations.
        """

        self.stacks = stacks
        self.operations = operations

    def arrange(self) -> None:
        """
        Perform the arrangement.
        """

        for operation in self.operations:
            quantity = operation[0]  # How many crates to move from the source stack to the target stack?
            source_stack = operation[1] - 1
            target_stack = operation[2] - 1

            # ? STEP #1: Copy the crates to the target stack.
            self.stacks[target_stack][0:0] = reversed(self.stacks[source_stack][0:quantity])
            # ? STEP #2: Remove the copied creates from the source stack.
            self.stacks[source_stack] = [
                item
                for idx, item in enumerate(self.stacks[source_stack])
                if idx > (quantity - 1)
            ]

    @property
    def top_crates(self) -> str:
        """
        Return the top crates in string form.
        """

        return ''.join([stack[0] for stack in self.stacks])


def parseStacks(stack: list[str]) -> list[list[str]]:
    """
    Return a list of stacks containing crates.
    """

    result = []
    at_the_top = True  # True if we're currently parsing the top of the stacks.
    current_stack_index = 0

    for line in stack:
        current_stack_index = 0  # Reset the current stack index because we're done with the top of the stack.
        char_idx = 0
        if '[' not in line:
            break  # If there are no crates, we can assume that the previous line was the end of the drawing.

        while char_idx < len(line):  # Use a while loop because we'll manipulate the index number.
            char = line[char_idx]
            if char == '[':  # Check for a crate in a stack.
                if at_the_top or current_stack_index >= len(result):
                    result.append([])

                result[current_stack_index].append(line[char_idx + 1])
                current_stack_index += 1
                char_idx += 3  # Skip the next closing square bracket and space.

            elif char == ' ':
                if at_the_top:
                    result.append([])

                current_stack_index += 1
                char_idx += 3  # Skip the next three spaces.

            else:
                raise ValueError(f"Unknown character `{char}` in line `{line}")

            char_idx += 1

        at_the_top = False

    return result


def parseOperations(stack: list[str]) -> list[tuple[int, int, int]]:
    result = []
    for line in stack:
        if not line.startswith("move"):
            continue  # Skip non-commands.

        quantity = int(line.partition(" from ")[0].partition("move ")[2])
        from_stack = int(line.partition(" to ")[0].partition(" from ")[2])
        to_stack = int(line.partition(" to ")[2])
        result.append((quantity, from_stack, to_stack))

    return result


def main() -> int:
    with open(os.path.join("..", "stack.txt"), 'r') as f:
        stack = f.read().split('\n')

    stacks = parseStacks(stack)
    operations = parseOperations(stack)

    crane = Crane(stacks, operations)
    crane.arrange()
    print(crane.top_crates)

    return 0


if __name__ == "__main__":
    sys.exit(main())
