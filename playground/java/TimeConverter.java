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

import java.util.Scanner;

public class TimeConverter {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int days = scanner.nextInt();

		//your code goes here
    System.out.println(days * (24 * 3600));
	}
}
