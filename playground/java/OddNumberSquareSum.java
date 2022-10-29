// Output the sum of the squares of all the odd numbers between
// firstnum and secondnum inclusive.

import java.util.Scanner;

public class OddNumberSquareSum
{
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        int firstnum, secondnum;
        int sum = 0;

        System.out.print("Enter first num: ");
        firstnum = user_input.nextInt();
        System.out.print("Enter second num: ");
        secondnum = user_input.nextInt();

        while (firstnum <= secondnum)
        {
            if (firstnum % 2 != 0) sum += firstnum * firstnum;
            firstnum++;
        }

        System.out.println(sum);
    }
}
