from time import time


class QuickFind:
    r"""
    This class provides methods for the quick find algorithm.

        1--------2        3-.      4
                 |           \     |
                 |            \    |
                 |             \   |
                 |              \  |
        5--------6        7      '-8

    In this example, the groups are as follows:

        {1, 2, 5, 6}
        {3, 4, 8}
        {7}

    When checking the connection of p and q, we just need to
    check if they have the same ID (group).

    When connecting p and q, we need to iterate through the list
    and check if they have the same ID as p. If so, change its ID
    to the ID of q.
    """

    def __init__(self, length: int):
        """
        :param length: The size of the list in type<int>.
        """

        self.__list = []  # Initialize an empty list.

        for i in range(0, length):  # Set the group number of each index to their index number.
            self.__list.append(i)

    def _getList(self) -> list[int]:
        return self.__list

    def getGroup(self, x: int) -> int:
        """
        Get the id (group) of x.
        """

        return self.__list[x]

    def getGroups(self) -> dict[int, list[int]]:
        """
        Return a dictionary containing {<group number>: <list of indexes>}
        """

        result = {}  # Initialize an empty dictionary.

        for index, group in enumerate(self.__list):
            if group not in result:
                result[group] = [index]  # Create a new group and add index to it as its first value.

            else:
                result[group].append(index)  # Add index to the existing list.

        return result

    def union(self, p: int, q: int) -> None:
        """
        Group p and q.
        """

        p_group = self.__list[p]  # Get the group of p.
        q_group = self.__list[q]  # Get the group of q.

        # Move all indexes in p_group and move them to q_group.
        for index, group in enumerate(self.__list):
            if group == p_group:
                self.__list[index] = q_group

    def connected(self, p: int, q: int) -> bool:
        """
        Evaluate whether p and q are connected or not.

        :returns bool: Returns True if p and q are connected. Otherwise, returns False.
        """

        return self.__list[p] == self.__list[q]


def main():
    QFDemo: QuickFind = QuickFind(int(input("Enter the amount of indexes to create: ")))
    max_groups_to_list = 10
    while True:
        print()
        print('=' * 30)
        print()
        print("Groups:")
        groups = QFDemo.getGroups()
        for i, group in enumerate(groups):
            if i >= max_groups_to_list:  # only list groups 0 to <max_groups_to_list>.
                print(f"... ({len(groups) - (i)} groups more)")
                break

            print(f"\tGroup #{group}: {', '.join(str(i) for i in groups[group])}")

        print()
        print("OPTIONS:")
        print()
        print("[01] Check if an index (p) has the same group (ID) as another index (q).")
        print("[02] Join two indexes p and q.")
        print("[03] See individual indexes")
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
            if QFDemo.connected(p, q):
                sentence_negation = ""

            else:
                sentence_negation = "not "

            total_time = time() - start_time

            print(f"p ({QFDemo.getGroup(p)}) and q ({QFDemo.getGroup(q)}) are {sentence_negation}connected.")
            print(f"Time spent: {total_time}")

        elif option == 2:
            p = int(input("Enter p: "))
            q = int(input("Enter q: "))
            print()
            print(f"ID (group) of p ({p}) and q ({q}) before union: {QFDemo.getGroup(p)}, {QFDemo.getGroup(q)}")
            start_time = time()
            QFDemo.union(p, q)
            total_time = time() - start_time
            print(f"ID (group) of p ({p}) and q ({q}) after union: {QFDemo.getGroup(p)}, {QFDemo.getGroup(q)}")
            print(f"Time spent: {total_time}")

        elif option == 3:
            print()
            for index, group in enumerate(QFDemo._getList()):
                if index > max_groups_to_list:
                    print(f"... ({len(QFDemo._getList()) - (index - 1)} indexes more)")
                    break

                print(f"Index {index}: id (group): {QFDemo.getGroup(index)}")

            print()


if __name__ == "__main__":
    main()
