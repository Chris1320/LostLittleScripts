/**
 * Given two int values, return their sum. Unless the two values are the same,
 * then return double their sum.
 * 
 * sumDouble(1, 2) → 3
 * sumDouble(3, 2) → 5
 * sumDouble(2, 2) → 8
 */

class TestCase {
    int a, b, expected;

    public TestCase(int a, int b, int expected) {
        this.a = a;
        this.b = b;
        this.expected = expected;
    }
}

class sumDouble {
    public static int sumDouble(int a, int b) {
        return a == b
                ? (a + b) * 2
                : a + b;
    }

    public static void main(String[] args) {
        TestCase[] testcases = {
                new TestCase(1, 2, 3),
                new TestCase(3, 2, 5),
                new TestCase(2, 2, 8),
                new TestCase(-1, 0, -1),
                new TestCase(3, 3, 12),
                new TestCase(0, 0, 0),
                new TestCase(0, 1, 1),
                new TestCase(3, 4, 7)
        };

        for (int i = 0; i < testcases.length; i++) {
            var tc = testcases[i];
            System.out.printf("%d, %d == %d (%d)%n",
                    tc.a, tc.b, sumDouble(tc.a, tc.b), tc.expected);
        }
    }
}
