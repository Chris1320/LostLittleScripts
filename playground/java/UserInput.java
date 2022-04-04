import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
    {
        System.out.println("Enter your name: ");
        Scanner name = new Scanner(System.in);
        System.out.println("Hi, " + name.nextLine() + '!');
    }
}
