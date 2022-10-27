import java.util.Scanner;

public class ValueChecker
{
    public static void main(String[] args)
    {
        var user_input = new Scanner(System.in);
        int number;

        System.out.print("Enter a number: ");
        number = user_input.nextInt();

        if (number == 7) System.out.println("That's lucky!");
        else if (number == 13) System.out.println("That's unlucky!");
        else System.out.println("That number is neither lucky nor unlucky!");
    }
}
