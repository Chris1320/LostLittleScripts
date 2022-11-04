import java.util.Scanner;
import java.util.Arrays;

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
            System.out.printf("Number %d: ", i + 1);
            nums[i] = user_input.nextInt();

            if (i == 0)  // Initialize highest and lowest with value of `nums[0]`.
            {
                highest = nums[i];  // set the current array element to highest value.
                lowest = nums[i];
            }
        }

        for (int i = 0; i < array_length; i++)
        {
            if (nums[i] > highest) highest = nums[i];  // check if element is higher than current highest value.
            if (nums[i] < lowest) lowest = nums[i];  // check if element is lower than current lowest value.
        }

        for (int i = 0; i < array_length; i++)
        {
            if (nums[i] == lowest) lowest_index = i;
            else if (nums[i] == highest) highest_index = i;
        }

        System.out.printf("Lowest value is %d at index %d.\n", lowest, lowest_index);
        System.out.printf("Highest value is %d at index %d.\n", highest, highest_index);
        System.out.printf("Original array is %s\n", Arrays.toString(nums));
    }
}
