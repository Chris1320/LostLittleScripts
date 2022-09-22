#!/usr/bin/env python3

import os
import sys


class Decimal:
    """
    This class performs conversion from Decimal to Binary, Octal, and Hexadecimal.

    All three methods below follow the same rules.
    The only difference is that binary uses base 2, octal
    uses 8, and hexadecimal uses 16 to perform division.
    """

    def __init__(self, value: int):
        self.value = value

    def __call__(self) -> None:
        """
        Print the value in three number systems.
        """

        print(f"Decimal:     {self.value}")
        print(f"Binary:      {self.toBinary()}")
        print(f"Octal:       {self.toOctal()}")
        print(f"Hexadecimal: {self.toHexadecimal()}")
        print()

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


class Binary:
    """
    This class performs conversion from Binary to Decimal, Octal, and Hexadecimal.
    """

    def __init__(self, value: str):
        while value[0] == '0':
            value = value[1:]

        self.value = value

    def __call__(self) -> None:
        """
        Print the value in three number systems.
        """

        print(f"Decimal:     {self.toDecimal()}")
        print(f"Binary:      {self.value}")
        print(f"Octal:       {self.toOctal()}")
        print(f"Hexadecimal: {self.toHexadecimal()}")
        print()

    def toDecimal(self) -> int:
        """
        Convert to decimal number system.

        This method determines the place value of each binary digit, and then adding it
        to `result` if the binary digit is `1`.

        :returns int:
        """

        place_value = 1  # The place value of the right-most binary digit.
        result = 0

        for digit in self.value[::-1]:
            if digit == '1':
                result += place_value

            place_value = place_value * 2  # Get the place value of the next binary digit.

        return result

    def toOctal(self) -> str:
        """
        Convert to octal number system.

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
        Convert to hexadecimal number system.

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


class Octal:
    """
    This class performs conversion from Octal to Binary, Decimal, and Hexadecimal.
    """

    def __init__(self, value: str):
        while value[0] == '0':
            value = value[1:]

        self.value = value

    def __call__(self) -> None:
        """
        Print the value in three number systems.
        """

        print(f"Decimal:     {self.toDecimal()}")
        print(f"Binary:      {self.toBinary()}")
        print(f"Octal:       {self.value}")
        print(f"Hexadecimal: {self.toHexadecimal()}")
        print()

    def toDecimal(self) -> int:
        """
        Convert to decimal number system.

        This method determines the value of each octal digit
        (`digit * 8^exponent`), and then adding it to `result`.

        :returns int:
        """

        exponent = 0  # The exponent of the right-most binary digit.
        result = 0

        for digit in self.value[::-1]:
            result += int(digit) * (8 ** exponent)

            exponent += 1  # Get the place value of the next octal digit.

        return result

    def toBinary(self) -> str:
        """
        Convert to binary number system.

        This method determines which "bits" to turn on to make a binary number
        with the same value as the source number. (Octal number)
        """

        result = ""

        for digit in self.value:
            remaining = int(digit)
            chunk_value = [0, 0, 0]  # Values: [4, 2, 1]
            if remaining >= 4:
                chunk_value[0] = 1
                remaining -= 4

            if remaining >= 2:
                chunk_value[1] = 1
                remaining -= 2

            if remaining >= 1:
                chunk_value[2] = 1
                remaining -= 1

            result += ''.join(map(str, chunk_value))

        while result[0] == '0':
            result = result[1:]  # Remove leading 0s.

        return result

    def toHexadecimal(self) -> str:
        """
        Convert to hexadecimal number system.

        There is no way to directly convert from octal to hexadecimal so
        we're going to convert from octal to decimal, and decimal to hexadecimal.
        """

        return Decimal(self.toDecimal()).toHexadecimal()


class Hexadecimal:
    """
    This class performs conversion from Hexadecimal to Decimal, Binary, and Octal.
    """

    def __init__(self, value: str):
        while value[0] == '0':
            value = value[1:]

        self.value = value.upper()
        self.letters = {
            'A': 10,
            'B': 11,
            'C': 12,
            'D': 13,
            'E': 14,
            'F': 15
        }

    def __call__(self) -> None:
        """
        Print the value in three number systems.
        """

        print(f"Decimal:     {self.toDecimal()}")
        print(f"Binary:      {self.toBinary()}")
        print(f"Octal:       {self.toOctal()}")
        print(f"Hexadecimal: {self.value}")
        print()

    def toDecimal(self) -> int:
        """
        Convert to decimal number system.

        This method determines the value of each hex digit,
        and then adding it to `result`.

        :returns int:
        """

        exponent = 0  # The exponent of the right-most binary digit.
        result = 0

        for digit in self.value[::-1]:
            digit = self.letters[digit] if not digit.isdigit() else digit
            result += int(digit) * (16 ** exponent)

            exponent += 1  # Get the place value of the next octal digit.

        return result

    def toBinary(self) -> str:
        """
        Convert to binary number system.
        """

        result = ""

        for digit in self.value:
            remaining = int(digit) if digit.isdigit() else self.letters[digit]
            chunk_value = [0, 0, 0, 0]  # Values: [8, 4, 2, 1]
            if remaining >= 8:
                chunk_value[0] = 1
                remaining -= 8

            if remaining >= 4:
                chunk_value[1] = 1
                remaining -= 4

            if remaining >= 2:
                chunk_value[2] = 1
                remaining -= 2

            if remaining >= 1:
                chunk_value[3] = 1
                remaining -= 1

            result += ''.join(map(str, chunk_value))

        while result[0] == '0':
            result = result[1:]

        return result

    def toOctal(self) -> str:
        """
        Convert to octal number system.

        This will convert from hex to decimal, and then decimal to octal since there is
        no way to directly convert from hex to dec.
        """

        return Decimal(self.toDecimal()).toOctal()


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
                try:
                    Decimal(int(source_value))()
                    input("Press enter to continue...")

                except Exception as e:
                    print("[ERROR] Invalid decimal number.")
                    input("Press enter to continue...")

            elif source_base == 2:
                cancel_operation = False
                for digit in source_value:
                    if digit not in ('0', '1'):
                        print("[ERROR] Invalid binary number.")
                        input("Press enter to continue...")
                        cancel_operation = True

                if not cancel_operation:
                    Binary(source_value)()
                    input("Press enter to continue...")

            elif source_base == 3:
                cancel_operation = False
                for digit in source_value:
                    try:
                        if int(digit) > 7 or int(digit) < 0:
                            print("[ERROR] Invalid octal number.")
                            input("Press enter to continue...")
                            cancel_operation = True

                    except (TypeError, ValueError):
                        print("[ERROR] Invalid octal number.")
                        input("Press enter to continue...")
                        cancel_operation = True

                if not cancel_operation:
                    Octal(source_value)()
                    input("Press enter to continue...")

            elif source_base == 4:
                cancel_operation = False
                for digit in source_value:
                    if not digit.isdigit():
                        if digit.upper() not in ('A', 'B', 'C', 'D', 'E', 'F'):
                            print("[ERROR] Invalid hexadecimal number.")
                            input("Press enter to continue...")
                            cancel_operation = True

                if not cancel_operation:
                    Hexadecimal(source_value)()
                    input("Press enter to continue...")

            else:
                print("[ERROR] Unknown base system.")
                return 2

        except (TypeError, ValueError):
            input("[ERROR] The choice you entered does not exist. Press enter to continue...")
            continue

        except Exception as e:
            print(f"[ERROR] An unhandled exception occured: {e}")
            return 1

    return 0


if __name__ == "__main__":
    sys.exit(main())
