import time

def main():
    # Create a list of items.
    group: list[int] = []  # The elements are the "group numbers" and the index are the items.
                # If the items have the same group number, they are connected to each other.

    r"""
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
    """

    for i in range(0, int(input("How many elements do you want in the array? > "))):
        group.append(i)

    while True:
        print("Groups:")
        groups: dict[int, list[int, ...]] = {}
        for index, group_number in enumerate(group):
            if group_number not in groups:
                groups[group_number]: list[int] = [index]

            else:
                groups[group_number].append(index)

        for g in groups:
            print(f"Group {g}: {', '.join(str(x) for x in groups[g])}")

        print("\n")
        print("Options:")
        print("[01] Check if an element (p) is connected to another element (q).")
        print("[02] Connect an element (p) to another element (q).")
        print("[99] Quit")
        print()
        option = int(input(" >>> "))
        if option == 99:
            return 0

        elif option == 1:
            p = int(input("Enter p: "))
            q = int(input("Enter q: "))
            start_time = time.time()
            try:
                if group[p] == group[q]:
                    print("p and q are connected to each other.")

                else:
                    print("p and q are not connected to each other.")

            except IndexError:
                print("One or more of the elements is not in the array.")
                continue

            print(f"Evaluation Time: {time.time() - start_time}s")

        elif option == 2:
            p = int(input("Enter p: "))
            q = int(input("Enter q: "))
            try:
                id_p = group[p]  # The group number of p
                id_q = group[q]  # The group number of q

            except IndexError:
                print("One or more of the elements is not in the array.")
                continue

            start_time = time.time()
            for index, group_number in enumerate(group):
                if group_number == id_p:  # Check if the group number of the current element is p.
                    group[index] = id_q  # If so, change the group number of the current element to q.

            # In the end, all elements in group p must be connected to q.
            print(f"Evaluation Time: {time.time() - start_time}s")


if __name__ == "__main__":
    main()
