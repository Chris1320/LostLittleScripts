#!/usr/bin/env python3

import os
import sys


class Decimal():
    """
    This class performs conversion from Decimal to Binary, Octal, and Hexadecimal.

    All three methods below follow the same rules.
    The only difference is that binary uses base 2, octal
    uses 8, and hexadecimal uses 16 to perform division.
    """

    def __init__(self, value: int):
        self.value = value

    def toBinary(self) -> str:
        """
        Convert to Binary number system.

        :returns str: The binary form of the decimal.
        """

        quotient = self.value
        result = ""

        while quotient > 0:
            # print(f"{quotient} / 2 = {quotient / 2} | {quotient // 2} | r: {quotient % 2}")
            result += str(quotient % 2)  # Get the remainder of the current value.
            quotient = quotient // 2  # Perform integer division.

        return result[::-1]  # Reverse the result to get the correct binary number.

    def toOctal(self) -> str:
        """
        Convert to Octal number system.

        :returns str: The octal form of the decimal.
        """

        quotient = self.value
        result = ""

        while quotient > 0:
            result += str(quotient % 8)
            quotient = quotient // 8

        return result[::-1]

    def toHexadecimal(self) -> str:
        """
        Convert to Hexadecimal number system.

        :returns str: The hex form of the decimal.
        """

        quotient = self.value
        result = ""
        letters = {
            10: 'A',
            11: 'B',
            12: 'C',
            13: 'D',
            14: 'E',
            15: 'F'
        }

        while quotient > 0:
            remainder = quotient % 16  # Get the remainder.
            # If remainder is > 10, replace it with equivalent hex letter.
            result += str(remainder) if remainder < 10 else letters[remainder]
            quotient = quotient // 16

        return result[::-1]


class Binary():
    """
    This class performs conversion from Binary to Decimal, Octal, and Hexadecimal.
    """

    def __init__(self, value: str):
        self.value = value

    def toDecimal(self) -> int:
        """
        Convert to decimal.

        This method determines the place value of each binary digit, and then adding it
        to `result` if the binary digit is `1`.

        :returns int:
        """

        base = 1  # The place value of the right-most binary digit.
        result = 0

        for digit in self.value[::-1]:
            if digit == '1':
                result += base

            base = base * 2  # Get the place value of the next binary digit.

        return result

    def toOctal(self) -> str:
        """
        Convert to octal.

        This method uses the "splicing" method, where you divide the
        binary number into three digits, and then checking the value of each chunks.

        :returns int:
        """

        value = str(self.value)[::-1]  # Reverse the value because we are processing it from right to left.
        result = ""

        while len(value) % 3 != 0:
            value += '0'  # Pad 0s to the value.

        # print(self.value)
        # print(value)
        while len(value) > 0:
            chunk_value = 0
            current_chunk = value[0:3]  # Get the 3 right-most digits.
            value = value[3:]  # Remove the three right-most digits.

            # print(current_chunk)

            if current_chunk[0] == '1':
                chunk_value += 1

            if current_chunk[1] == '1':
                chunk_value += 2

            if current_chunk[2] == '1':
                chunk_value += 4

            result += str(chunk_value)

        return result[::-1]

    def toHexadecimal(self) -> str:
        """
        Convert to hexadecimal.

        This method uses the "splicing" method, where you divide the
        binary number into four digits, and then checking the value of each chunks.

        :returns int:
        """

        value = str(self.value)[::-1]  # Reverse the value because we are processing it from right to left.
        result = ""
        letters = {
            10: 'A',
            11: 'B',
            12: 'C',
            13: 'D',
            14: 'E',
            15: 'F'
        }

        while len(value) % 4 != 0:
            value += '0'  # Pad 0s to the value.

        # print(self.value)
        # print(value)
        while len(value) > 0:
            chunk_value = 0
            current_chunk = value[0:4]  # Get the 4 right-most digits.
            value = value[4:]  # Remove the four right-most digits.

            # print(current_chunk)

            if current_chunk[0] == '1':
                chunk_value += 1

            if current_chunk[1] == '1':
                chunk_value += 2

            if current_chunk[2] == '1':
                chunk_value += 4

            if current_chunk[3] == '1':
                chunk_value += 8

            result += str(chunk_value) if chunk_value < 10 else letters[chunk_value]

        return result[::-1]


class Octal():
    """
    This class performs conversion from Octal to Binary, Decimal, and Hexadecimal.
    """

    def __init__(self, value: str):
        self.value = value

    def toDecimal(self) -> int:
        """
        Convert to decimal.

        This method determines the value of each octal digit
        (`digit * 8^exponent`), and then adding it to `result`.
        """

        exponent = 0  # The exponent of the right-most binary digit.
        result = 0

        for digit in self.value[::-1]:
            result += int(digit) * (8 ** exponent)

            exponent += 1  # Get the place value of the next octal digit.

        return result

    # TODO: def toBinary(self) -> str:


def clrscrn() -> None:
    """
    Clears the screen.
    """

    if sys.platform == "win32":
        os.system("cls")  # We can also use subprocess.

    else:  # On Linux: 'linux'
        os.system("clear")


def main() -> int:
    """
    The main function of the program.

    :returns int: The exit code.
    """

    while True:
        try:
            clrscrn()
            print()
            print("Base Converter")
            print()
            print("[01] Decimal")
            print("[02] Binary")
            print("[03] Octal")
            print("[04] Hexadecimal")
            print()
            print("[99] Quit")
            print()
            source_base: int = int(input("What is the base of the source number? > "))
            if (source_base < 1 or source_base > 4) and source_base != 99:
                input("[ERROR] The choice you entered does not exist. Press enter to continue...")
                continue

            if source_base == 99:
                print("Quitting...")
                break

            source_value: str = input("Enter the source number: ")
            if source_base == 1:
                return Decimal(source_value)()

            elif source_base == 2:
                return Binary(source_value)()

            elif source_base == 3:
                return Octal(source_value)()

            elif source_base == 4:
                return Hexadecimal(source_value)()

            else:
                print("[ERROR] Unknown base system.")
                return 2

        except Exception as e:
            print(f"[ERROR] An unhandled exception occured: {e}")
            return 1

    return 0


if __name__ == "__main__":
    sys.exit(main())

