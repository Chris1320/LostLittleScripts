#include <stdio.h>  // Include stdio.h

int main()  // The main function of the program.
{
    char name[20];  // Declare a string of 20 characters.
    int subjects, _;  // Declare variable subjects with type int.
    float total_grade = 0.0;  // Declare total_grade with type float and assign value 0.0 to it.

    printf("Enter student name: ");  // Show prompt.
    scanf("%20s", name);  // Read user input.
    // We don't need to pass the address of name when it is a string.

    printf("\nHow many subjects do you have? > ");  // Show prompt.
    scanf("%i", &subjects);  // Read user input.

    float grades[subjects];  // Create an array of type float with length <subjects>.

    for (_ = 0; _ < subjects; _++)  // Ask user for the grades of each subject.
    {
        printf("Enter grade #%i: ", _ + 1);
        scanf("%f", &grades[_]);
    }

    putchar('\n');  // Put a newline to stdout.

    printf("Student Name: %s\n", name);
    printf("Number of Subjects: %i\n\n", subjects);

    for (_ = 0; _ < subjects; _++)  // Add all values from the array and put it into total_grade.
    {
        printf("\t- Subject #%i: %.2f\n", _ + 1, grades[_]);
        total_grade += grades[_];
    }
    total_grade /= subjects;  // Divide total_grade to number of subjects.

    printf("\nAverage Score: %.2f\n", total_grade);

    if (total_grade < 70) printf("[E] You failed...\n");  // Show if grade is 0-69
    else if (total_grade >= 70 && total_grade < 80) printf("[D] You barely made it.\n");  // Show if 70-79
    else if (total_grade >= 80 && total_grade < 90) printf("[C] That's good.\n");  // Show if 80-89
    else if (total_grade >= 90 && total_grade < 96) printf("[B] That's great!\n");  // Show if 90-95
    else printf("[A] Excellent!\n");  // Show if 96-100

    return 0;
}
