public class InsertionSortExample
{
    public static void main(String[] args)
    {
        int[] arr = {5, 1, 22, 4, 88, 2, 8, 11, 44, 55};  // The array to be sorted.

        System.out.printf("Unsorted array: %s\n", java.util.Arrays.toString(arr));

        // The actual insertion sort algorithm:
        // We start the curr_idx at 1 because we will compare
        // it to the elements to its left side.
        for (int curr_idx = 1; curr_idx < arr.length; curr_idx++) {
            // We need to store the value of the current index
            // because we will be overwriting it in the while loop below.
            int curr_val = arr[curr_idx];
            int prev_idx = curr_idx - 1;  // The index to the left of curr_idx.

            // We will keep moving the elements to the right until
            // we find the correct position for the current value.
            while (prev_idx >= 0 && curr_val < arr[prev_idx])
                arr[prev_idx + 1] = arr[prev_idx--];

            // We have found the correct position for the current
            // value so we can now insert it into the array.
            arr[prev_idx + 1] = curr_val;
        }

        System.out.printf("Sorted array:   %s\n", java.util.Arrays.toString(arr));
    }
}
