/**
 * The parameter weekday is true if it is a weekday, and the parameter vacation
 * is true if we are on vacation. We sleep in if it is not a weekday or we're on
 * vacation. Return true if we sleep in.
 * 
 * sleepIn(false, false) → true
 * sleepIn(true, false) → false
 * sleepIn(false, true) → true
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class sleepInSolution {
    public static boolean sleepIn(boolean weekday, boolean vacation) {
        return !weekday || vacation;
    }

    public static void main(String[] args) {
        boolean[][] testcases = {
                // weekday, vacation, expected
                { false, false, true },
                { true, false, false },
                { false, true, true },
                { true, true, true },
        };
        for (int i = 0; i < testcases.length; i++) {
            boolean[] tc = testcases[i];
            boolean result = sleepIn(tc[0], tc[1]);
            System.out.printf("%b, %b => %b (%b)%n", tc[0], tc[1], result, tc[2]);
        }
    }
}
