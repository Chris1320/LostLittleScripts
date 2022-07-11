from time import time

class QuickUnion:
    """
    The class
    """

    def __init__(self, length: int):
        """
        :param length: The length of the list in type<int>.
        """

        self.__list = []  # Initialize an empty list.
        for i in range(0, length):
            self.__list.append(i)  # Set the default root of each index to itself.

    def getGroups(self) -> dict[int, list[int]]:
        """
        Return a dictionary containing {<group number>: [<list of indexes>]}
        """

        result = {}
        for index, group in enumerate(self.__list):
            # In this case, index is the item, group is the parent of index, and
            # root is the root of the tree (top-most item of the tree).
            root = self.getRoot(index)  # Get the root ID of the index.
            if root not in result:
                result[root] = [index]

            else:
                result[root].append(index)

        return result

    def getRoot(self, x: int) -> int:
        """
        Get the root of x.
        """
        
        while self.__list[x] != x:  # Check if the ID of x is equal to itself.
            return self.getRoot(self.__list[x])

        return x

    def union(self, p: int, q: int) -> None:
        """
        Connect p and q together.
        """

        q_root = self.getRoot(q)  # Get the root of p.
        self.__list[self.getRoot(p)] = q_root  # Merge p_root to q_root.

    def connected(self, p: int, q: int) -> bool:
        """
        Evaluate whether p and q are connected to each other.

        :returns: True is p and q are connected. Otherwise, False.
        """

        return self.getRoot(p) == self.getRoot(q)


def main():
    QUDemo: QuickUnion = QuickUnion(int(input("Enter the amount of indexes to create: ")))
    max_groups_to_list = 10
    while True:
        print()
        print('=' * 30)
        print()
        print("Groups:")
        groups = QUDemo.getGroups()
        for i, group in enumerate(groups):
            if i > max_groups_to_list:  # only list groups 0 to <max_groups_to_list>.
                print(f"... ({len(groups) - (i - 1)} groups more)")
                break

            print(f"\tGroup #{group}: {', '.join(str(i) for i in groups[group])}")

        print()
        print("OPTIONS:")
        print()
        print("[01] Check if an index (p) has the same group (ID) as another index (q).")
        print("[02] Join two indexes p and q.")
        print()
        print("[99] Quit")
        print()
        print()
        option = int(input(" >>> "))

        if option == 99:
            return

        elif option == 1:
            p = int(input("Enter p: "))
            q = int(input("Enter q: "))
            print()
            start_time = time()
            if QUDemo.connected(p, q):
                sentence_negation = ""

            else:
                sentence_negation = "not "

            total_time = time() - start_time

            print(f"p ({QUDemo.getRoot(p)}) and q ({QUDemo.getRoot(q)}) are {sentence_negation}connected.")
            print(f"Time spent: {total_time}")

        elif option == 2:
            p = int(input("Enter p: "))
            q = int(input("Enter q: "))
            print()
            print(f"ID (group) of p ({p}) and q ({q}) before union: {QUDemo.getRoot(p)}, {QUDemo.getRoot(q)}")
            start_time = time()
            QUDemo.union(p, q)
            total_time = time() - start_time
            print(f"ID (group) of p ({p}) and q ({q}) after union: {QUDemo.getRoot(p)}, {QUDemo.getRoot(q)}")
            print(f"Time spent: {total_time}")


main()
