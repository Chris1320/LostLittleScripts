#include <stdio.h>

int main()
{
    char name[20];
    int subjects, _;
    float total_grade = 0.0;

    printf("Enter student name: ");
    scanf("%20s", &name);
    printf("\nHow many subjects do you have? > ");
    scanf("%i", &subjects);

    float grades[subjects];

    for (_ = 0; _ < subjects; _++)
    {
        printf("\nEnter grade #%i: ", _ + 1);
        scanf("%f", &grades[_]);
    }
    putchar('\n');
    for (_ = 0; _ < subjects; _++)
    {
        printf("Subject #%i: %f\n", _ + 1, grades[_]);
        total_grade += grades[_];
    }
    total_grade /= subjects;
    printf("Total: %f\n", total_grade);
    return 0;
}
