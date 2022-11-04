import java.util.Scanner;

public class ForLoops
{
    public static void main(String[] args)
    {
        var user_input = new Scanner(System.in);
        int max_nums;

        System.out.print("How many numbers to print? > ");
        max_nums = user_input.nextInt();

        System.out.printf("Printing %d numbers...\n", max_nums);
        for (int i = 1; i <= max_nums; i++)
        {
            /*
             * for (<initialization>; <condition>; <iteration>)
             * {
             *     <code>
             * }
             *
             * 1. Java initializes variables `i` with value 0.
             * 2. It checks the condition.
             * 3. If the condition is true, perform the code. Otherwise, break the loop.
             * 4. After executing the code inside the code blocks, perform the iteration.
             */
            System.out.println(i);
        }
    }
}
