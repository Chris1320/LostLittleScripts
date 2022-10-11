/*
 * Two Fer
 *
 * `Two-fer` or `2-fer` is short for two for one. One for you and one for me.
 * Given a name, return a string with the message:
 *
 * One for name, one for me.
 *
 * Where "name" is the given name.
 * However, if the name is missing, return the string:
 *
 * One for you, one for me.
 *
 * Here are some examples:
 *
 * | Name  | Output                     |
 * |-------|----------------------------|
 * | Alice | One for Alice, one for me. |
 * | Bob   | One for Bob, one for me.   |
 * |       | One for you, one for me.   |
 *
 */

using System;

public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string name = "you") => "One for "  + name + ", one for me.";

    public static void Main(string[] args)
    {
        Console.WriteLine(Speak());
        Console.WriteLine(Speak("Alice"));
    }
}
