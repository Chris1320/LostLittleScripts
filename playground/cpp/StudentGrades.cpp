/*
 * Computing Student Grades
 *
 * Imagine a course in which each student's final exam counts for 40% of the final grade,
 * the midterm exam counts for 20%, and the average homework grade makes up the
 * remaining 40%.
 *
 * Problem Source: "Accelerated C++: Practical Programming by Example", Chapter 3.1
 */

#include <iostream>
#include <iomanip>  // provides `std::setprecision`

#define PRECISION 4

using std::cin;
using std::cout;
using std::string;

int main()
{
    // Define and declare variables.
    double final_exam_grade, midterm_exam_grade;
    double homework_grade;
    string name;

    // grade weights
    double final_exam_grade_weight = 0.4;
    double midterm_exam_grade_weight = 0.2;
    double homework_grade_weight = 0.4;

    // These will be used in a loop so set iv to 0.
    double total_homework_grades = 0;
    int homework_count = 0;

    cout << "Please enter your name: ";
    cin >> name;

    cout << "Please enter your mid-term and final exam grades: ";
    cin >> midterm_exam_grade >> final_exam_grade;

    cout << "Please enter all your homework grades. Enter <CTRL+D> when done.\n\n";
    while (cin >> homework_grade)
    {
        homework_count++;
        total_homework_grades += homework_grade;
    }

    cout << "\n" << name << ", your final grade is " << std::setprecision(PRECISION) <<
        (final_exam_grade * final_exam_grade_weight) +
        (midterm_exam_grade * midterm_exam_grade_weight) +
        ((total_homework_grades / homework_count) * homework_grade_weight) <<
        "%." << std::endl;

    return 0;
}
