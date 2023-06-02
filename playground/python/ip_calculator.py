"""
A quick and dirty way to calculate
IP addresses, subnet masks, and networks.

Made in an hour, might be buggy af.
"""

import sys


class IPAddress:
    """
    An object representation of an IP address.
    """

    def __init__(self, ip: str):
        if len(ip) == 35:  # 32 bits, including the dots.
            ip = IPAddress._toDecimal(ip)

        if not IPAddress.isValidIP(ip):
            raise ValueError("Invalid IP address.")

        self.ip: str = ip  # decimal form

    @property
    def decimal(self) -> str:
        return self.ip

    @property
    def binary(self) -> str:
        return IPAddress._toBinary(self.ip)

    @staticmethod
    def isValidIP(ip_to_check: str) -> bool:
        """
        Check if an IP address is in its valid decimal form.
        """

        ip: list[str] = ip_to_check.split('.')

        if len(ip) != 4:
            return False

        for octet in ip:
            if not 0 <= int(octet) <= 255:
                return False

        return True

    @staticmethod
    def _toBinary(decimal_ip: str) -> str:
        """
        Convert an IP address to its binary representation.
        """

        return '.'.join(
            [
                bin(int(x) + 256)[3:]
                for x in decimal_ip.split('.')
            ]
        )

    @staticmethod
    def _toDecimal(binary_ip: str) -> str:
        """
        Convert a binary representation of an IP address to its decimal representation.
        """

        return '.'.join(
            [
                str(int(x, 2))
                for x in binary_ip.split('.')
            ]
        )


class SubnetMask(IPAddress):
    def __init__(self, mask_or_cidr: str):
        if mask_or_cidr.startswith('/'):
            # if parameter is a CIDR.
            mask = SubnetMask._toMask(int(mask_or_cidr[1:]))

        elif len(mask_or_cidr) == 35:
            # if parameter is an IP in binary form.
            mask = SubnetMask._toDecimal(mask_or_cidr)

        else:
            mask = mask_or_cidr

        if not SubnetMask.isValidIP(mask):
            raise ValueError("Invalid subnet mask.")

        self.ip: str = mask # decimal form

    @property
    def cidr(self) -> int:
        return SubnetMask._toCIDR(self.ip)

    @staticmethod
    def _toCIDR(mask: str) -> int:
        return SubnetMask._toBinary(mask).count('1')

    @staticmethod
    def _toMask(cidr: int) -> str:
        """
        Convert a CIRD (like `/24`) to its decimal representation (255.255.255.0).
        """

        mask: str = ''
        for i in range(4):
            if i < cidr // 8:
                mask += '255.'

            elif i == cidr // 8:
                mask += str(256 - 2**(8 - cidr % 8)) + '.'

            else:
                mask += '0.'

        return mask[:-1]


def main() -> int:
    while True:
        print('=' * 40)
        print("What do you want to do?")
        print()
        print("[01] IP address conversion")
        print("[02] Subnet mask conversion")
        print("[03] [WIP] Get subnet mask from number of hosts")
        print("[04] [WIP] Get network information")
        print("[05] [WIP] Design a network!")
        print()
        print("[99] Exit")
        print()
        try:
            selection = int(input("Enter your selection: "))

        except ValueError:
            print("Invalid selection.")
            continue

        if selection == 99:
            break

        elif selection == 1:
            try:
                ip = IPAddress(input("Enter IP address: "))
                print()
                print(f"Decimal: {ip.decimal}")
                print(f"Binary:  {ip.binary}")
                print()

            except ValueError as e:
                print(e)
                print()

        elif selection == 2:
            try:
                mask = SubnetMask(input("Enter subnet mask (prefix with `/` for CIDR): "))
                print()
                print(f"Decimal: {mask.decimal}")
                print(f"Binary:  {mask.binary}")
                print(f"CIDR:    {mask.cidr}")

            except ValueError as e:
                print(e)
                print()


    return 0


if __name__ == "__main__":
    sys.exit(main())
