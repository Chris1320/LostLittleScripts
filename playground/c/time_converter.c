/*
 * Time Converter
 *
 * You need a program to convert days to seconds.
 * The given code takes the amount of days as input.
 * Complete the code to convert it to seconds and output the result.
 *
 * Sample Input:
 * 12
 *
 * Sample Output:
 * 1036800
 */

#include <stdio.h>

int main()
{
    int day;

    scanf("%d", &day);
    printf("%d\n", (day * (24 * 3600)));
    return 0;
}
