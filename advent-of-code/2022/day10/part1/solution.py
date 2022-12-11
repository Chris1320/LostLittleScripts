import os
import sys

register: dict[str, int] = {'x': 1}  # We might have a few variables in the next part.
cycles_to_get = (20, 60, 100, 140, 180, 220)  # Get the signal value of the following cycles.
total_signal_strength = 0  # The answer
cycle = 0


def addCycle(cycles_to_add: int) -> None:
    """
    This function helps checking for conditions on each cycle.
    """

    global total_signal_strength
    global cycles_to_get
    global register
    global cycle

    for i in range(0, cycles_to_add):
        cycle += 1
        if cycle in cycles_to_get:
            print(f"Signal Strength at cycle #{cycle}: {cycle * register['x']}")
            total_signal_strength += cycle * register['x']


def main() -> int:
    global total_signal_strength
    global cycles_to_get
    global register
    global cycle

    # ? Read the file.
    with open(os.path.join("..", "opcodes.txt"), 'r') as f:
        opcodes = f.read().split('\n')

    # ? Check commands from file.
    for opcode in opcodes:
        if opcode == "noop":
            addCycle(1)
            continue

        elif opcode.startswith("add"):
            addCycle(2)
            register[opcode.partition("add")[2].partition(' ')[0]] += int(opcode.partition(' ')[2])

    print(f"Total Signal Strength: {total_signal_strength} (Ended at cycle #{cycle})")
    return 0


if __name__ == "__main__":
    sys.exit(main())
