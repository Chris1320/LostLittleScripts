/**
 * Given 2 ints, a and b, return true if one if them is 10 or if their sum is
 * 10.
 * 
 * makes10(9, 10) → true
 * makes10(9, 9) → false
 * makes10(1, 9) → true
 */

class TestCase {
    int a, b;
    boolean expected;

    public TestCase(int a, int b, boolean expected) {
        this.a = a;
        this.b = b;
        this.expected = expected;
    }
}

class makes10 {
    public static boolean makes10(int a, int b) {
        return a == 10 || b == 10 ? true : a + b == 10;
    }

    public static void main(String[] args) {
        TestCase[] testCases = {
                new TestCase(9, 10, true),
                new TestCase(9, 9, false),
                new TestCase(1, 9, true),
                new TestCase(10, 1, true),
                new TestCase(10, 10, true),
                new TestCase(8, 2, true),
                new TestCase(8, 3, false),
                new TestCase(10, 42, true),
                new TestCase(12, -2, true)
        };

        for (TestCase testCase : testCases) {
            boolean result = makes10(testCase.a, testCase.b);
            System.out.printf("makes10(%d, %d) = %b | Expected: %b | %s%n",
                    testCase.a, testCase.b, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }
}
