/*
 * Referenced from "C by Dissection, 4th Edition"
 */

#include <stdio.h>

#define PI 3.141592653589793

int main()
{
    double radius;

    printf("Enter the radius of the circle: ");
    scanf("%lf", &radius);
    printf(
        "\n%s%s%.2f%s%.2f%s%.2f%s%f\n",
        "Area = PI * radius * radius\n",
        "     = ", PI, " * ", radius, " * ", radius,
        "\n     = ", PI * radius * radius
    );
}
