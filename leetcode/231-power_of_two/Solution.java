import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter a valid number: ");
        int n = user_input.nextInt();

        if (PowerOfTwo.isPowerOfTwo(n)) System.out.printf("%d is a power of two.\n", n);
        else System.out.printf("%d is not a power of two.\n", n);
        user_input.close();
    }
}

class PowerOfTwo
{
    public static boolean isPowerOfTwo(int n)
    {
        // This new solution takes advantage of the binary system,
        return (n > 0) && ((n & (n-1)) == 0);
        /*
        // This old solution will have a problem when calculating integers near int.MAX_VALUE.
        for (int i = 0, max = 0; max < n; i++)
        {
            System.out.printf("Max = %f, i = %d\n", Math.pow(2, i), i);
            if ((max = (int)Math.pow(2, i)) == n) return true;
        }

        return false;
        */
    }
}
