public class LinearSearch
{
    public static void main(String[] args)
    {
        int[] arr = {2, 4, 6, 8, 10, 12, 14};
        int value_to_find = 10;

        int index = find(arr, value_to_find);

        // Print the array and the value to find.
        System.out.printf("Array: %s\n", java.util.Arrays.toString(arr));
        System.out.printf("Value to find: %d\n", value_to_find);

        if (index == -1) System.out.println("Value not found");
        else System.out.printf("Value found at index %d of the array.\n", index);
    }

    public static int find(int[] arr, int value_to_find)
    {
        // Perform a linear search on the array, looking for the value.
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == value_to_find) return i;
        }

        return -1;  // Return -1 if the value is not found.
    }
}
