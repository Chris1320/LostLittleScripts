public class BinarySearch
{
    public static void main(String[] args)
    {
        int[] arr = {2, 7, 12, 20, 36, 37, 40, 56, 67, 99};
        int to_find = 37;

        System.out.printf("Array: %s\n", java.util.Arrays.toString(arr));
        System.out.printf("Number to find: %d\n", to_find);

        int index = find(arr, to_find);
        if (index != -1) System.out.printf("Found at index %d.\n", index);
        else System.out.println("Not found");
    }

    public static int find(int[] arr, int to_find)
    {
        int low = 0;  // Get the lowest index
        int high = arr.length - 1;  // Get the highest index

        while (low <= high) {  // Continue search while low to high range is valid.
            int mid = low + (high - low) / 2;  // Determine the middle index

            if (arr[mid] == to_find) return mid;  // The value is found.
            else if (arr[mid] < to_find) low = mid + 1;  // The value is in the upper half.
            else high = mid - 1;  // The value is in the lower half.
        }

        return -1;  // The value is not found.
    }
}
