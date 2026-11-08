/**
 * Given an int n, return true if it is within 10 of 100 or 200. Note:
 * Math.abs(num) computes the absolute value of a number.
 * 
 * nearHundred(93) → true
 * nearHundred(90) → true
 * nearHundred(89) → false
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class nearHundredTestCase {
    int n;
    boolean expected;

    public nearHundredTestCase(int n, boolean expected) {
        this.n = n;
        this.expected = expected;
    }
}

class nearHundredSolution {
    public static boolean nearHundred(int n) {
        int diff100 = Math.abs(100 - n);
        int diff200 = Math.abs(200 - n);
        return diff100 <= 10 || diff200 <= 10;
    }

    public static void main(String[] args) {
        nearHundredTestCase[] testCases = {
                new nearHundredTestCase(93, true),
                new nearHundredTestCase(90, true),
                new nearHundredTestCase(89, false),
                new nearHundredTestCase(110, true),
                new nearHundredTestCase(111, false),
                new nearHundredTestCase(121, false),
                new nearHundredTestCase(-101, false),
                new nearHundredTestCase(-209, false),
                new nearHundredTestCase(190, true),
                new nearHundredTestCase(209, true),
                new nearHundredTestCase(0, false),
                new nearHundredTestCase(5, false),
                new nearHundredTestCase(-50, false),
                new nearHundredTestCase(191, true),
                new nearHundredTestCase(189, false),
                new nearHundredTestCase(200, true),
                new nearHundredTestCase(210, true),
                new nearHundredTestCase(211, false),
                new nearHundredTestCase(290, false),
        };

        for (nearHundredTestCase testCase : testCases) {
            boolean result = nearHundred(testCase.n);
            System.out.printf("nearHundred(%d) = %b | Expected: %b | %s%n",
                    testCase.n, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }

}
