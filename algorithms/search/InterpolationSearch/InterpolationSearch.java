public class InterpolationSearch
{
    public static void main(String[] args)
    {
        int[] arr = {2, 4, 8, 16, 32, 64, 128, 256, 512, 1024};
        int to_find = 256;

        System.out.printf("Array: %s\n", java.util.Arrays.toString(arr));
        System.out.printf("Value to find: %d\n", to_find);

        int result = find(arr, to_find);
        System.out.printf("Found %d at index %d\n", to_find, result);
    }

    public static int find(int[] arr, int value)
    {
        // Set the low and high boundaries.
        int low = 0, high = arr.length - 1;

        // Loop until the value is found and the boundaries are not crossed.
        while (value >= arr[low] && value <= arr[high] && low <= high) {
            // Calculate the probe position.
            int probe = low + (high - low) * (value - arr[low]) / (arr[high] - arr[low]);
            System.out.printf("Probe: %d\n", probe);

            if (arr[probe] < value) low = probe + 1;  // Continue searching to the right.
            else if (arr[probe] > value) high = probe - 1;  // Continue searching to the left.
            else return probe;  // Value is found.
        }

        return -1;  // Return -1 if the value is not found.
    }
}
