"""
A quick and dirty way to calculate IP addresses and subnet masks.

Made in an hour.
"""

import sys


def ipToBinary(ip: str) -> str:
    """
    Convert an IP address to its binary representation.
    """

    return '.'.join([bin(int(x)+256)[3:] for x in ip.split('.')])


def binaryToIp(binary: str) -> str:
    """
    Convert a binary representation of an IP address to its decimal representation.
    """

    return '.'.join([str(int(x, 2)) for x in binary.split('.')])


def maskToCidr(mask: str) -> int:
    return ipToBinary(mask).count('1')


def cidrToMask(cidr: int) -> str:
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


def isValidIp(ip_to_check: str) -> bool:
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


def getNetworkInfo(ip: str, mask: str) -> tuple[str, str, str, str, str]:
    """
    Get the following network information:

    - Broadcast address
    - Number of usable addresses
    - First usable address
    - Last usable address.
    """

    broadcast: str = ''
    usable: int = 0
    first: str = ''
    last: str = ''

    ip_binary: str = ipToBinary(ip)
    mask_binary: str = ipToBinary(mask)

    for i in range(4):
        broadcast += str(int(ip_binary.split('.')[i], 2) |
                         (255 - int(mask_binary.split('.')[i], 2))) + '.'

    broadcast = broadcast[:-1]

    usable = 2**(32 - maskToCidr(mask)) - 2

    first = binaryToIp(ipToBinary(ip)[:-1] + '1')
    last = binaryToIp(ipToBinary(broadcast)[:-1] + '0')

    return (ip, broadcast, str(usable), first, last)


def getNextIp(ip: str, interval: int) -> str:
    """
    Get the next IP address in the network.
    """

    network_octets: list[str] = ip.split('.')
    network_octets[3] = str(int(network_octets[3]) + interval)

    return '.'.join(network_octets)


def main() -> int:
    while True:
        print('=' * 40)
        print("What do you want to do?")
        print()
        print("[01] IP Address")
        print("[02] Subnet Mask")
        print("[03] Get Network Information")
        print("[04] Design a network!")
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
            # detect if the IP address is in decimal or binary form.
            ip = input("Enter IP address: ")
            if len(ip) == 35:  # 32 bits, including the dots.
                print(f"Decimal: {binaryToIp(ip)}")

            elif isValidIp(ip):
                print(f"Binary: {ipToBinary(ip)}")

            else:
                print("Invalid IP address.")

        elif selection == 2:
            # detect if the subnet mask is in decimal or CIDR form.
            mask = input("Enter subnet mask (prefix with `/` for CIDR): ")
            if mask.startswith('/'):
                try:
                    print(f"Decimal: {cidrToMask(int(mask[1:]))}")

                except ValueError:
                    print("Invalid CIDR.")

            elif isValidIp(mask):
                print(f"CIDR: {maskToCidr(mask)}")

            else:
                print("Invalid subnet mask.")

        elif selection == 3:
            ip = input("Enter IP address: ")
            mask = input("Enter subnet mask: ")

            # convert IP and mask to decimal representation if it's in binary/CIDR form.
            if len(ip) == 35:
                ip = binaryToIp(ip)

            if mask.startswith('/'):
                try:
                    mask = cidrToMask(int(mask[1:]))

                except ValueError:
                    print("Invalid CIDR.")
                    continue

            if isValidIp(ip) and isValidIp(mask):
                network, broadcast, usable, first, last = getNetworkInfo(
                    ip, mask)

                print()
                print(f"Network address:            {network}")
                print(f"Broadcast address:          {broadcast}")
                print(f"Number of usable addresses: {usable}")
                print(f"First usable address:       {first}")
                print(f"Last usable address:        {last}")

            else:
                print("Invalid IP address or subnet mask.")

        elif selection == 4:
            ip = input("Enter first network IP address: ")
            mask = input("Enter first subnet mask: ")
            networks = int(input("Enter number of networks to make: "))

            if len(ip) == 35:
                ip = binaryToIp(ip)

            if mask.startswith('/'):
                try:
                    mask = cidrToMask(int(mask[1:]))

                except ValueError:
                    print("Invalid CIDR.")
                    continue

            # get the interval between networks using the subnet mask.
            interval = 2**(32 - maskToCidr(mask))

            print()
            print(f"Network Interval: {interval}")
            print("Networks:")
            for i in range(networks):
                network, broadcast, usable, first, last = getNetworkInfo(ip, mask)
                print()
                print(f"Network {i}:")
                print(f"    Network address:            {network}")
                print(f"    Broadcast address:          {broadcast}")
                print(f"    Number of usable addresses: {usable}")
                print(f"    First usable address:       {first}")
                print(f"    Last usable address:        {last}")
                # Increment network address by the interval.
                ip = getNextIp(ip, interval)

    return 0


if __name__ == "__main__":
    sys.exit(main())
