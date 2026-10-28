/**
 * Given an int n, return true if it is within 10 of 100 or 200. Note:
 * Math.abs(num) computes the absolute value of a number.
 * 
 * nearHundred(93) → true
 * nearHundred(90) → true
 * nearHundred(89) → false
 */

class TestCase {
    int n;
    boolean expected;

    public TestCase(int n, boolean expected) {
        this.n = n;
        this.expected = expected;
    }
}

class nearHundred {
    public static boolean nearHundred(int n) {
        int diff100 = Math.abs(100 - n);
        int diff200 = Math.abs(200 - n);
        return diff100 <= 10 || diff200 <= 10;
    }

    public static void main(String[] args) {
        TestCase[] testCases = {
                new TestCase(93, true),
                new TestCase(90, true),
                new TestCase(89, false),
                new TestCase(110, true),
                new TestCase(111, false),
                new TestCase(121, false),
                new TestCase(-101, false),
                new TestCase(-209, false),
                new TestCase(190, true),
                new TestCase(209, true),
                new TestCase(0, false),
                new TestCase(5, false),
                new TestCase(-50, false),
                new TestCase(191, true),
                new TestCase(189, false),
                new TestCase(200, true),
                new TestCase(210, true),
                new TestCase(211, false),
                new TestCase(290, false),
        };

        for (TestCase testCase : testCases) {
            boolean result = nearHundred(testCase.n);
            System.out.printf("nearHundred(%d) = %b | Expected: %b | %s%n",
                    testCase.n, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }

}
