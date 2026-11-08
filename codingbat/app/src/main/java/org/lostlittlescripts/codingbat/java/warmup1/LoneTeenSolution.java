/**
 * We'll say that a number is "teen" if it is in the range 13..19 inclusive.
 * Given 2 int values, return true if one or the other is teen, but not both.
 * 
 * loneTeen(13, 99) → true
 * loneTeen(21, 19) → true
 * loneTeen(13, 13) → false
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class loneTeenTestCase {
    int a, b;
    boolean expected;

    public loneTeenTestCase(int a, int b, boolean expected) {
        this.a = a;
        this.b = b;
        this.expected = expected;
    }
}

class loneTeenSolution {
    public static boolean loneTeen(int a, int b) {
        // XOR? XOR...
        return (a >= 13 && a <= 19) ^ (b >= 13 && b <= 19);
    }

    public static void main(String[] args) {
        var testcases = new loneTeenTestCase[] {
                new loneTeenTestCase(13, 99, true),
                new loneTeenTestCase(21, 19, true),
                new loneTeenTestCase(13, 13, false),
                new loneTeenTestCase(14, 20, true),
                new loneTeenTestCase(20, 15, true),
                new loneTeenTestCase(16, 17, false),
                new loneTeenTestCase(16, 9, true),
                new loneTeenTestCase(16, 18, false),
                new loneTeenTestCase(13, 19, false),
                new loneTeenTestCase(13, 20, true),
                new loneTeenTestCase(6, 18, true),
                new loneTeenTestCase(99, 13, true),
                new loneTeenTestCase(99, 99, false)
        };

        for (var test : testcases) {
            var result = loneTeen(test.a, test.b);
            System.out.printf("loneTeen(%d, %d) → %b | expected: %b | %s\n", test.a, test.b, result, test.expected,
                    result == test.expected ? "PASS" : "FAIL");
        }
    }
}
