/**
 * We'll say that a number is "teen" if it is in the range 13..19 inclusive.
 * Given 2 int values, return true if one or the other is teen, but not both.
 * 
 * loneTeen(13, 99) → true
 * loneTeen(21, 19) → true
 * loneTeen(13, 13) → false
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

class loneTeen {
    public static boolean loneTeen(int a, int b) {
        // XOR? XOR...
        return (a >= 13 && a <= 19) ^ (b >= 13 && b <= 19);
    }

    public static void main(String[] args) {
        var testcases = new TestCase[] {
                new TestCase(13, 99, true),
                new TestCase(21, 19, true),
                new TestCase(13, 13, false),
                new TestCase(14, 20, true),
                new TestCase(20, 15, true),
                new TestCase(16, 17, false),
                new TestCase(16, 9, true),
                new TestCase(16, 18, false),
                new TestCase(13, 19, false),
                new TestCase(13, 20, true),
                new TestCase(6, 18, true),
                new TestCase(99, 13, true),
                new TestCase(99, 99, false)
        };

        for (var test : testcases) {
            var result = loneTeen(test.a, test.b);
            System.out.printf("loneTeen(%d, %d) → %b | expected: %b | %s\n", test.a, test.b, result, test.expected,
                    result == test.expected ? "PASS" : "FAIL");
        }
    }
}
