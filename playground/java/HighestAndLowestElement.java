import java.util.Arrays;
import java.util.Scanner;

public class HighestAndLowestElement
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        Scanner user_input = new Scanner(System.in);
        int array_length, highest = 0, lowest = 0;
        int lowest_index = -1, highest_index = -1;  // There is no -1 index anyway.

        // ? Ask user how many numbers to insert to array.
        System.out.print("How many inputs? > ");
        array_length = user_input.nextInt();

        // ? Create new integer array.
        int[] nums = new int[array_length];

        for (int i = 0; i < array_length; i++)
        {
            // Ask for array elements.
            System.out.printf("Number #%d: ", i + 1);
            nums[i] = user_input.nextInt();

            if (i == 0)  // Initialize highest and lowest with value of `nums[0]`.
            {
                highest = nums[i];  // set the current array element to highest value.
                lowest = nums[i];
                highest_index = i;
                lowest_index = i;
            }
            else  // Compare `nums[i]` with the current highest and lowest values.
            {
                if (nums[i] > highest)  // check if element is higher than current highest value.
                {
                    highest = nums[i];
                    highest_index = i;
                }
                if (nums[i] < lowest)  // check if element is lower than current lowest value.
                {
                    lowest = nums[i];
                    lowest_index = i;
                }
            }
        }

        if (nums.length < 1) System.out.println("The array is empty.");
        else
        {
            System.out.printf("Lowest value is %d at index %d.\n", lowest, lowest_index);
            System.out.printf("Highest value is %d at index %d.\n", highest, highest_index);
        }

        System.out.printf("\nOriginal array is %s\n", Arrays.toString(nums));
    }
}
