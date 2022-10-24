import java.util.Scanner;

public class VolumeOfACircle
{
    public static void main(String[] args)
    {
        // Define and initialize variables
        final float PI = 3.14159F;
        var user_input = new Scanner(System.in);
        double radius;

        System.out.print("Enter the radius of the circle: ");
        radius = user_input.nextDouble();

        System.out.printf(
            "The volume of a circle with a radius of %s is %s.",
            radius,
            PI * (radius * radius)
        );
        user_input.close();
    }
}
