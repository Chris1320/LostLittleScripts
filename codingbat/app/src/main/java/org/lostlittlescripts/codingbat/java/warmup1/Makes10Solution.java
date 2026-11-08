/**
 * Given 2 ints, a and b, return true if one if them is 10 or if their sum is
 * 10.
 * 
 * makes10(9, 10) → true
 * makes10(9, 9) → false
 * makes10(1, 9) → true
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class makes10TestCase {
    int a, b;
    boolean expected;

    public makes10TestCase(int a, int b, boolean expected) {
        this.a = a;
        this.b = b;
        this.expected = expected;
    }
}

class makes10Solution {
    public static boolean makes10(int a, int b) {
        return a == 10 || b == 10 || a + b == 10;
    }

    public static void main(String[] args) {
        makes10TestCase[] testCases = {
                new makes10TestCase(9, 10, true),
                new makes10TestCase(9, 9, false),
                new makes10TestCase(1, 9, true),
                new makes10TestCase(10, 1, true),
                new makes10TestCase(10, 10, true),
                new makes10TestCase(8, 2, true),
                new makes10TestCase(8, 3, false),
                new makes10TestCase(10, 42, true),
                new makes10TestCase(12, -2, true)
        };

        for (makes10TestCase testCase : testCases) {
            boolean result = makes10(testCase.a, testCase.b);
            System.out.printf("makes10(%d, %d) = %b | Expected: %b | %s%n",
                    testCase.a, testCase.b, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }
}
