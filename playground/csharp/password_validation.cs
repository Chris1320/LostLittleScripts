/*
 * Password Evaluation
 *
 * You're interviewing to join a security team. They want to see you build a
 * password evaluator for your technical interview to validate the input.
 *
 * Task:
 *
 * Write a program that takes in a string as input and evaluates it as a
 * valid password. The password is valid if it has at a minimum 2 numbers,
 * 2 of the following special characters ('!', '@', '#', '$', '%', '&', '*'),
 * and a length of at least 7 characters.
 * If the password passes the check, output 'Strong', else output 'Weak'.
 *
 * Input Format:
 * A string representing the password to evaluate.
 *
 * Output Format:
 * A string that says 'Strong' if the input meets the requirements, or 'Weak', if not
 *
 * Sample Input:
 * Hello@$World19
 *
 * Sample Output:
 * Strong
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static int Main(string[] args)
        {
            // Declare variables
            string password;
            int i, nums = 0, symbols = 0, req_nums = 2, req_symbols = 2;  // Assign values to 4 variables
            
            Console.Write("Enter your password: ");  // Ask for user input.
            password = Console.ReadLine();
            
            if (password.Length < 7) Console.WriteLine("Weak\n");  // Check if password length is good.
            else
            {
                for (i = 0; i < password.Length; i++)  // Iterate through characters of password.
                {
                    if (Char.IsDigit(password[i])) nums++;  // If char is number, do nums++
                    else if (Char.IsSymbol(password[i]) || Char.IsPunctuation(password[i])) symbols++;  // If char is symbol or punctuation, do symbols++.
                }
                if (nums >= req_nums && symbols >= req_symbols) Console.WriteLine("Strong\n");  // Check if requirements are met.
                else Console.WriteLine("Weak\n");
            }

            return 0;
        }
    }
}

