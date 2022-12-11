import os
import sys

register: dict[str, int] = {'x': 1}  # We might have a few variables in the next part.
cycles_to_get = (20, 60, 100, 140, 180, 220)  # Get the signal value of the following cycles.
pixel_off = '.'
pixel_on = '#'
cycle = 0
crt_x = 0
crt_y = 0
crt_max_x = 40  # The CRT monitor is 40 characters wide.
crt_max_y = 6  # The CRT monitor is 6 lines high.
line = ""


def addCycle(cycles_to_add: int) -> None:
    """
    This function helps checking for conditions on each cycle.
    """

    global cycles_to_get
    global crt_max_x
    global crt_max_y
    global pixel_off
    global pixel_on
    global register
    global cycle
    global crt_x
    global crt_y
    global line

    for i in range(0, cycles_to_add):
        cycle += 1  # FIXME: why is the first few pixels of the first letter is not present? Oh well, I can read it anyway...
        line += pixel_on \
            if crt_x in range(  # n-1 to n+1
                (register['x'] - 1) % crt_max_x,
                (register['x'] + 2) % crt_max_x
            ) \
            else pixel_off
        if cycle % 40 == 0:
            print(line)  # Flush
            line = ''

        crt_x = (crt_x + 1) % crt_max_x
        crt_y = (crt_y + 1) % crt_max_y


def main() -> int:
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

    print(f"\nEnded at cycle #{cycle}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
