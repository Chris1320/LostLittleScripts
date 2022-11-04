import java.util.Scanner;

public class IndexOfElement
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);
        int array_length, value_to_find;
        int found_index = -1;  // If found_index is -1, then the value is not found.

        // ? Ask for user input.
        System.out.print("How many inputs? > ");
        array_length = user_input.nextInt();

        int[] nums = new int[array_length];  // Create a new integer array.

        // ? Fill up the array.
        for (int i = 0; i < array_length; i++)
        {
            System.out.print("Enter Number: ");
            nums[i] = user_input.nextInt();
        }

        System.out.print("Enter a specific value: ");
        value_to_find = user_input.nextInt();  // Ask what to find.

        // Find the index of value_to_find.
        for (int i = 0; i < nums.length; i++)
        {
            if (nums[i] == value_to_find)
            {
                found_index = i;
                break;  // break out of the loop.
            }
        }

        if (found_index == -1) System.out.println("Value is not found in array.");
        else System.out.printf("The index of value %d is %d.\n", value_to_find, found_index);

        user_input.close();
    }
}
