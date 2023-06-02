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

        self._ip: str = ip  # decimal form

    @property
    def decimal(self) -> str:
        return self._ip

    @property
    def binary(self) -> str:
        return IPAddress._toBinary(self.decimal)

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
            mask = SubnetMask._CIDRToMask(int(mask_or_cidr[1:]))

        elif len(mask_or_cidr) == 35:
            # if parameter is an IP in binary form.
            mask = SubnetMask._toDecimal(mask_or_cidr)

        else:
            mask = mask_or_cidr

        if not SubnetMask.isValidIP(mask):
            raise ValueError("Invalid subnet mask.")

        self._ip: str = mask # decimal form

    @property
    def cidr(self) -> int:
        return SubnetMask._maskToCIDR(self.decimal)

    @property
    def total(self) -> int:
        """
        Get the total number of addresses in a subnet.
        """

        return 2 ** (32 - self.cidr)

    @property
    def usable(self) -> int:
        """
        Get the number of usable addresses in a subnet.
        """

        return self.total - 2

    @staticmethod
    def _maskToCIDR(mask: str) -> int:
        return SubnetMask._toBinary(mask).count('1')

    @staticmethod
    def _CIDRToMask(cidr: int) -> str:
        """
        Convert a CIDR (like `/24`) to its decimal representation (255.255.255.0).
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


class Network:
    def __init__(self, network_address: IPAddress, subnet_mask: SubnetMask):
        self._network_address = network_address
        self._subnet_mask = subnet_mask

    @property
    def network_address(self) -> IPAddress:
        return self._network_address

    @property
    def subnet_mask(self) -> SubnetMask:
        return self._subnet_mask

    @property
    def broadcast_address(self) -> IPAddress:
        return self.next(self.subnet_mask.total - 1)

    @property
    def first_and_last_usable(self) -> tuple[IPAddress, IPAddress]:
        return (self.next(1), self.next(self.subnet_mask.total - 2))

    @property
    def usable(self) -> int:
        return self.subnet_mask.usable

    @property
    def total(self) -> int:
        return self.subnet_mask.total

    def next(self, n: int) -> IPAddress:
        """
        Get the nth next IP address in the network.
        """

        network_octets: list[str] = self.network_address.decimal.split('.')

        while n > 0:
            if int(network_octets[3]) + n <= 255:
                network_octets[3] = str(int(network_octets[3]) + n)
                break

            else:
                n -= 256 - int(network_octets[3])
                network_octets[3] = '0'
                if int(network_octets[2]) + 1 <= 255:
                    network_octets[2] = str(int(network_octets[2]) + 1)
                    continue

                else:
                    network_octets[2] = '0'
                    if int(network_octets[1]) + 1 <= 255:
                        network_octets[1] = str(int(network_octets[1]) + 1)
                        continue

                    else:
                        network_octets[1] = '0'
                        if int(network_octets[0]) + 1 <= 255:
                            network_octets[0] = str(int(network_octets[0]) + 1)
                            continue

                        else:
                            raise ValueError("Too many hosts.")

        return IPAddress('.'.join(network_octets))

def getMaskFromNeededHosts(hosts: int, use_total: bool = False) -> SubnetMask | None:
    """
    Get the smallest subnet mask that can fit the number of hosts.
    If use_total is True, do not subtract broadcast and network address.
    """

    # loop from the smallest possible CIDR to the biggest and check if the hosts can fit there.
    if use_total:
        for i in range(32):
            if (2**i) >= hosts:
                return SubnetMask(f"/{32 - i}")

    else:
        for i in range(32):
            if (2**i) - 2 >= hosts:
                return SubnetMask(f"/{32 - i}")

    return None


def printNetworkInfo(ip: IPAddress, mask: SubnetMask, network: Network):
    print()
    print(f"Information about {ip.decimal}/{mask.cidr}:")
    print()
    print(f"Network address:      {network.network_address.decimal}")
    print(f"Subnet mask:          {network.subnet_mask.decimal} (/{network.subnet_mask.cidr})")
    try:
        print(f"Broadcast address:    {network.broadcast_address.decimal}")

    except ValueError as e:
        print(f"Broadcast address:    {e}")

    alt_interval = 'or 1' if network.subnet_mask.total == 256 else ''
    print(f"Interval:             {network.subnet_mask.total} {alt_interval}")
    print(f"Usable addresses:     {network.subnet_mask.usable}")
    try:
        print(f"First usable address: {network.first_and_last_usable[0].decimal}")
    except ValueError as e:
        print(f"Fist usable address:  {e}")

    try:
        print(f"Last usable address:  {network.first_and_last_usable[1].decimal}")

    except ValueError as e:
        print(f"Last usable address:  {e}")

    print()


def main() -> int:
    while True:
        print('=' * 40)
        print("What do you want to do?")
        print()
        print("[01] IP address conversion")
        print("[02] Subnet mask conversion")
        print("[03] Get subnet mask from number of usable hosts")
        print("[04] Get subnet mask from number of total hosts")
        print("[05] Get single network information")
        print("[06] Design a network! (Constant subnet mask)")
        print("[07] Design a network! (VLSM)")
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

        elif selection in (3, 4):
            use_total = True if selection == 4 else False
            try:
                hosts = int(input("Enter number of hosts needed: "))
                mask = getMaskFromNeededHosts(hosts, use_total)
                if mask is None:
                    print()    
                    print("No subnet mask can fit that many hosts.")

                else:
                    print()
                    print(f"This subnet mask can fit {mask.usable} hosts:")
                    print()
                    print(f"Decimal: {mask.decimal}")
                    print(f"Binary:  {mask.binary}")
                    print(f"CIDR:    /{mask.cidr}")

            except ValueError:
                print()
                print("Invalid number of hosts.")
                print()

        elif selection == 5:
            try:
                ip = IPAddress(input("Enter IP address: "))
                mask = SubnetMask(input("Enter subnet mask (prefix with `/` for CIDR): "))
                network = Network(ip, mask)

                printNetworkInfo(ip, mask, network)

            except ValueError as e:
                print(e)
                print()


        elif selection == 6:
            try:
                ip = IPAddress(input("Enter the first network's IP address: "))
                mask = SubnetMask(input("Enter the first network's subnet mask (prefix with `/` for CIDR): "))
                num_of_networks = int(input("Enter how many networks to make: "))

                for i in range(num_of_networks):
                    network = Network(ip, mask)
                    print()
                    print(f"Network #{i}:")
                    printNetworkInfo(ip, mask, network)
                    ip = network.next(mask.total)

            except ValueError as e:
                print(e)

        elif selection == 7:
            try:
                network_quantity = int(input("Enter how many networks to make: "))
                network_masks = []
                networks: list[Network] = []

                first_network_address = IPAddress(input("Enter the first network's IP address: "))

                print("Enter each network's information below:")
                print("    - enter a subnet mask, CIDR, or number of hosts")
                print("    - to enter a CIDR, prefix it with `/`")
                print("    - to enter a number of hosts, postfix it with `h`")
                for i in range(network_quantity):
                    while True:
                        try:
                            mask = input(f"Network #{i}: ")
                            if mask.endswith('h'):
                                hosts = int(mask[:-1])
                                mask = getMaskFromNeededHosts(int(mask[:-1]), False)
                                if mask is None:
                                    raise ValueError("No subnet mask can fit that many hosts.")

                                print(f"[i] Using /{mask.cidr} as the subnet mask for {hosts} hosts.")

                            else:
                                mask = SubnetMask(mask)

                            network_masks.append(mask)
                            break  # break the inner while loop

                        except ValueError as e:
                            print(e)
                            continue

                # sort network_masks by number of hosts
                network_masks.sort(key=lambda x: x.usable, reverse=True)

                print()
                print("Re-arranged network information:")
                for subnet in network_masks:
                    print(f"    - {subnet.decimal} (/{subnet.cidr}) {subnet.usable} hosts")

                for _, mask in enumerate(network_masks):
                    networks.append(Network(first_network_address, mask))
                    print([n.network_address.decimal for n in networks])
                    print(networks[-1].network_address.decimal)
                    first_network_address = networks[-1].next(mask.total)

                print()
                for idx, network in enumerate(networks):
                    print()
                    print(f"Network #{idx}:")
                    printNetworkInfo(network.network_address, network.subnet_mask, network)

            except ValueError as e:
                raise e

    return 0


if __name__ == "__main__":
    sys.exit(main())
