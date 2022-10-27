import java.util.Scanner;

public class AgeChecker
{
    public static void main(String[] args)
    {
        var user_input = new Scanner(System.in);
        int age;

        System.out.print("Enter your age: ");
        age = user_input.nextInt();

        if (age < 21) System.out.println("You are not allowed to enter.");
        else System.out.println("You are now allowed to enter.");
    }
}
