/*
 * Searching an element in the array using a key; The key element
 * sequentially compares every value in the array to check if the key is
 * present in the array or not.
 */

import java.util.Scanner;

public class Searching
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int[] nums = new int[10]; // Create an array of size 10.
        boolean number_found = false;

        // Insert 10 random numbers into the array.
        for (int i = 0; i < nums.length; i++)
            nums[i] = (int) (Math.random() * 100);

        System.out.print("Enter a number and see if it is in the array: ");
        int to_search = scanner.nextInt();

        // Print the contents of the array.
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == to_search) {
                System.out.printf("nums[%d] = %d <<< Your Number is Here!\n", i, nums[i]);
                number_found = true;  // Set the flag to true.
            }
            else System.out.printf("nums[%d] = %d\n", i, nums[i]);
        }

        // If the number is not found, print a message.
        if (!number_found) System.out.println("\nYour number is not in the array.");
        scanner.close();
    }
}
