public class Update {
    public static void main(String[] args)
    {
        int[] nums = new int[10]; // Create an array of size 10.

        // Insert 10 random numbers into the array.
        for (int i = 0; i < nums.length; i++)
            nums[i] = (int) (Math.random() * 100);

        // Print the contents of the array.
        System.out.println("Before updating:");
        for (int i = 0; i < nums.length; i++)
            System.out.printf("nums[%d] = %d\n", i, nums[i]);

        // Add 10 to each element in the array, effectively updating it.
        for (int i = 0; i < nums.length; i++)
            nums[i] += 10;

        // Print the contents of the array.
        System.out.println("\nAfter updating:");
        for (int i = 0; i < nums.length; i++)
            System.out.printf("nums[%d] = %d\n", i, nums[i]);
    }
}
