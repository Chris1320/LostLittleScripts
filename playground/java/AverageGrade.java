import java.util.Scanner;

public class AverageGrade
{
    public static void main(String[] args)
    {
        // ? Initialize and declare variables.
        var user_input = new Scanner(System.in);
        String name;
        int number_of_subjects;
        float average = 0.0F;  // Add default value for average grade.

        // ? Ask for user input.
        System.out.print("Enter the student's name: ");
        name = user_input.nextLine();
        System.out.print("How many subjects does the student have? > ");
        number_of_subjects = user_input.nextInt();

        // ? Create a new float array with length of <number_of_subjects>.
        float[] subject_grades = new float[number_of_subjects];

        // ? Initiate for loop to fill up the array with student's grades.
        for (int i = 0; i < number_of_subjects; i++)  // This is called a "for" loop.
        {
            System.out.printf("Enter the student's grade for subject #%s: ", i + 1);
            subject_grades[i] = user_input.nextFloat();
        }

        // ? Print the output.
        System.out.printf("\n%s's grades:\n", name);
        for (var subject_grade : subject_grades)  // This is called a "for each" loop.
        {
            System.out.printf("- %s%s\n", subject_grade, '%');
            average += subject_grade;  // While printing the grades, add it to <average>.
        }
        average = average / number_of_subjects;  // Divide the current value of <average> to get the actual average.
        System.out.printf("\nAverage Grade: %s%s", average, '%');
    }
}
