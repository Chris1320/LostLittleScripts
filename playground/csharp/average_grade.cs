using System;

namespace AverageGrade
{
    class Program
    {
        static int Main(string[] args)
        {
            string name;
            int i, number_of_subjects;
            double total_grade = 0;

            Console.Write("Enter student's name: ");
            name = Console.ReadLine();
            Console.Write("How many subjects do you have? > ");
            number_of_subjects = Convert.ToInt32(Console.ReadLine());
            // double[] grades = new double[number_of_subjects];
            for (i = 0; i < number_of_subjects; i++)
            {
                Console.Write("Enter grade #" + (i + 1) + " > ");
                total_grade += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\nStudent Name: " + name);
            Console.WriteLine("Average Grade: " + total_grade / number_of_subjects);
            return 0;
        }
    }
}