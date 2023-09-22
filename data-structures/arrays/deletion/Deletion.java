/*
 * In this array operation, we delete an element from the particular
 * index of an array. This deletion operation takes place as we assign
 * the value in the consequent index to the current index.
 */

import java.util.Scanner;

public class Deletion {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int[] nums = new int[10]; // Create an array of size 10.

        // Insert 10 random numbers into the array.
        for (int i = 0; i < nums.length; i++)
            nums[i] = (int) (Math.random() * 100);

        // Print the contents of the array.
        for (int i = 0; i < nums.length; i++)
            System.out.printf("nums[%d] = %d\n", i, nums[i]);

        // Ask the user what number to remove.
        System.out.print("Enter the index of the number to remove: ");
        int index = scanner.nextInt();

        // Check if the user entered an invalid index.
        if (index < 0 || index >= nums.length) {
            System.out.println("Invalid index.");
            System.exit(1);
        }

        // Delete the number at the given index.
        for (int i = index; i < nums.length - 1; i++)
            nums[i] = nums[i + 1]; // Shift the elements to the left.

        // Print the contents of the array.
        for (int i = 0; i < nums.length - 1; i++) // Note the length - 1 because we deleted an element.
            System.out.printf("nums[%d] = %d\n", i, nums[i]);

        // Close the scanner because the LSP is screaming at me.
        scanner.close();
    }
}
