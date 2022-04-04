import java.util.Scanner;

class SwitchCaseExpression
{
    public static void main(String[] args)
    {
        System.out.println("Enter a number 1-3: ");  // Fun fact: It's 23:53 when I'm writing this.
        int user_selected = new Scanner(System.in).nextInt();

        int sel = switch (user_selected) {
            case 1 -> 5;
            case 2 -> 10;
            case 3 -> 20;
            default -> 0;
        };
        System.out.println(sel);
    }
}
