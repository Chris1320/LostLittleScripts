/* Area of Rectangle
 *
 * You are writing a program to calculate
 * the area of a rectangle. Currently, it
 * takes the length and the height as inputs.
 *
 * Complete the given method to take them as
 * arguments, then calculate and return the area.
 *
 * Sample Input
 * 4
 * 5
 *
 * Sample Output
 * 20
 */

using System;

namespace AreaOfRectangle
{
    class Program
    {
        static double getArea(double length, double height)
        {
            return length * height;
        }

        static int Main(string[] args)
        {
            double length, height;

            // Get the rectangle's length and height.
            Console.Write("Enter the length of the rectangle: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height of the rectangle: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of a {length}x{height} rectangle is {getArea(length, height)}.");

            return 0;
        }
    }
}
