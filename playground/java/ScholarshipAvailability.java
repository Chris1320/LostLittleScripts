import java.util.Scanner;

public class ScholarshipAvailability
{
    public static void main(String[] args)
    {
        final int number_of_subjects = 10;

        var user_input = new Scanner(System.in);
        float average = 0.0F;
        float entered_grade;

        for (int i = 0; i < number_of_subjects; i++)
        {
            do  // Prevent user from entering a number outside of range 0-100
            {
                System.out.printf("Enter your grade for subject #%s: ", i + 1);
                entered_grade = user_input.nextFloat();
            }
            while (entered_grade < 0 || entered_grade > 100);

            average += entered_grade;
        }

        average = average / number_of_subjects;  // Divide the current value of <average> to get the actual average.
        System.out.printf("\nYour average: %.2f%s\n\n", average, '%');

        if (average >= 98.0F) System.out.println("President's List: You will get 100% off discount in tuition fee.");
        else if (average >= 95.0F) System.out.println("College Scholar: You will get 50% off discount in tuition fee.");
        else if (average >= 92.0F) System.out.println("Deans List: You will get 30% off discount in tuition fee.");
        else System.out.println("None: You will get 0% off discount in tuition fee.");
    }
}
