/*
 * The Spy Life
 *
 * You are a secret agent, and you receive an encrypted message that needs to be decoded.
 * The code that is being used flips the message backwards and inserts non-alphabetic
 * characters in the message to make it hard to decipher.
 *
 * Task
 * Create a program that will take the encoded message, flip it around, remove any
 * characters that are not a letter or a space, and output the hidden message.
 *
 * Input Format
 * A string of characters that represent the encoded message.
 *
 * Output Format
 * A string of character that represent the intended secret message.
 *
 * Sample Input
 * `d89%l++5r19o7W *o=l645le9H`
 *
 * Sample Output
 * `Hello World`
 */

import java.util.Scanner;
import java.lang.Character;
import java.lang.StringBuilder;

public class Solution
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        var user_input = new Scanner(System.in);
        var decoded_msg = new StringBuilder();
        String encoded_msg;

        // ? Ask user for the encoded message.
        System.out.print("Enter the encoded message: ");
        encoded_msg = user_input.nextLine();

        // ? start at the end of the encoded string to reverse the message.
        for (int i = encoded_msg.length() - 1; i >= 0; i--)
        {
            // ? If character is a letter or a space, add it to decoded_msg.
            if (Character.isLetter(encoded_msg.charAt(i)) || encoded_msg.charAt(i) == ' ')
            {
                decoded_msg.append(encoded_msg.charAt(i));
            }
        }

        System.out.printf("Decoded Message: %s\n", decoded_msg);
    }
}