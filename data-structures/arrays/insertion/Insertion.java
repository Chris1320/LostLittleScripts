/*
 * In the insertion operation, we are adding one or more elements
 * to the array. Based on the requirement, a new element can be added
 * at the beginning, end, or any given index of array. This is done
 * using input statements of the programming language.
 */

public class Insertion
{
    public static void main(String[] args)
    {
        int[] nums = new int[10]; // Create an array of size 10.

        // Insert 10 random numbers into the array.
        for (int i = 0; i < nums.length; i++)
            nums[i] = (int) (Math.random() * 100);

        // Print the contents of the array.
        for (int i = 0; i < nums.length; i++)
            System.out.printf("nums[%d] = %d\n", i, nums[i]);
    }
}
