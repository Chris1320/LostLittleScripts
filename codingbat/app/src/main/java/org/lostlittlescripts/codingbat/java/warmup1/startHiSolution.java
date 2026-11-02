/**
 * Given a string, return true if the string starts with "hi" and false
 * otherwise.
 * 
 * startHi("hi there") → true
 * startHi("hi") → true
 * startHi("hello hi") → false
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class startHiTestCase {
    String input;
    boolean expected;

    public startHiTestCase(String input, boolean expected) {
        this.input = input;
        this.expected = expected;
    }
}

class startHiSolution {
    public static boolean startHi(String str) {
        return str.startsWith("hi");
    }

    public static void main(String[] args) {
        startHiTestCase[] testCases = {
                new startHiTestCase("hi there", true),
                new startHiTestCase("hi", true),
                new startHiTestCase("hello hi", false),
                new startHiTestCase("he", false),
                new startHiTestCase("h", false),
                new startHiTestCase("", false),
                new startHiTestCase("ho hi", false),
                new startHiTestCase("hi ho", true)
        };

        for (var input : testCases) {
            var result = startHi(input.input);
            System.out.printf(
                    "Input: %s | Output: %b (Expected: %b)%n",
                    input.input, result, input.expected);
        }
    }
}
