/**
 * Given three int values, a b c, return the largest.
 *
 * intMax(1, 2, 3) → 3
 * intMax(1, 3, 2) → 3
 * intMax(3, 2, 1) → 3
 */

class intMax {
    public static int intMax(int a, int b, int c) {
        return Math.max(a, Math.max(b, c));
    }

    public static void main(String[] args) {
        int[][] testcases = {
                // a, b, c, expected;
                { 1, 2, 3, 3 },
                { 1, 3, 2, 3 },
                { 3, 2, 1, 3 },
                { 9, 3, 3, 9 },
                { 3, 9, 3, 9 },
                { 3, 3, 9, 9 },
                { 8, 2, 3, 8 },
                { -3, -1, -2, -1 },
                { 6, 2, 5, 6 },
                { 5, 6, 2, 6 },
                { 5, 2, 6, 6 }
        };

        for (var testcase : testcases) {
            var result = intMax(testcase[0], testcase[1], testcase[2]);
            System.out.printf("%d, %d, %d = %d (%s)\n", testcase[0], testcase[1], testcase[2], result,
                    testcase[3] == result ? "PASS" : "FAIL");
        }
    }
}
