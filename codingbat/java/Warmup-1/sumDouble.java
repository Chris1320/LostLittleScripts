/**
 * Given two int values, return their sum. Unless the two values are the same,
 * then return double their sum.
 * 
 * sumDouble(1, 2) → 3
 * sumDouble(3, 2) → 5
 * sumDouble(2, 2) → 8
 */

class sumDouble {
    public static int sumDouble(int a, int b) {
        return a == b
                ? (a + b) * 2
                : a + b;
    }

    public static void main(String[] args) {
        int[][] testcases = {
                { 1, 2, 3 },
                { 3, 2, 5 },
                { 2, 2, 8 },
                { -1, 0, -1 },
                { 3, 3, 12 },
                { 0, 0, 0 },
                { 0, 1, 1 },
                { 3, 4, 7 }
        };

        for (int i = 0; i < testcases.length; i++) {
            var tc = testcases[i];
            System.out.printf("%d, %d == %d (%d)%n",
                    tc[0], tc[1], sumDouble(tc[0], tc[1]), tc[2]);
        }
    }
}
