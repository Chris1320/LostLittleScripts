def quicksort(arr):
    if len(arr) <= 1:
        return arr
    else:
        pivot = arr[0]  # Choose the first element as the pivot
        less = [x for x in arr[1:] if x <= pivot]
        greater = [x for x in arr[1:] if x > pivot]
        print(less, greater)
        return quicksort(less) + [pivot] + quicksort(greater)


# Example Usage
my_list = ["E", "X", "A", "M", "P", "L", "E"]
sorted_list = quicksort(my_list)
print(sorted_list)
