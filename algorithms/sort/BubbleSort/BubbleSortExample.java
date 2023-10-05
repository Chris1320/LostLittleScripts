public class BubbleSortExample
{
    public static void main(String[] args)
    {
        int[] arr = {5, 1, 22, 4, 88, 2, 8, 11, 44, 55};  // The array to be sorted.

        System.out.printf("Unsorted array: %s\n", java.util.Arrays.toString(arr));

        // The actual bubble sort algorithm:
        // i = The number of elements that have been sorted.
        // j = The loop for the current element.
        for (int i = 0; i < arr.length; i++) {
            // Leave the last i elements as they are already sorted.
            for (int j = 1; j < arr.length - i; j++) {
                // If the previous element is greater than the current element, swap them.
                if (arr[j - 1] > arr[j]) {
                    // Swap the elements' places.
                    arr[j] = arr[j - 1] + arr[j] - (arr[j - 1] = arr[j]);
                    // This is a longer but more readable method:
                    // int dummy = arr[j];  // Put the element into a temporary variable.
                    // arr[j] = arr[j - 1];  // Move the j-1 element to element j.
                    // arr[j - 1] = dummy; // Move the element from dummy var to j - 1.
                }
            }
        }

        System.out.printf("Sorted array:   %s\n", java.util.Arrays.toString(arr));
    }
}
