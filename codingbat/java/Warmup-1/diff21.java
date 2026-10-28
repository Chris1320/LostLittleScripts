class TestCase {
    int num, expected;
}

class diff21 {
    public static int diff21(int n) {
        int result = Math.abs(n - 21);
        return n > 21 ? result * 2 : result;
    }

    public static void main(String[] args) {
        int[][] testcases = {
                { 19, 2 },
                { 10, 11 },
                { 21, 0 },
                { 22, 2 },
                { 25, 8 },
                { 30, 18 },
                { 0, 21 },
                { 1, 20 },
                { 2, 19 },
                { -1, 22 },
                { -2, 23 },
                { 50, 58 },
        };

        for (int i = 0; i < testcases.length; i++) {
            var res = diff21(testcases[i][0]);
            System.out.printf("%d => %d (%s)%n", testcases[i][0], res, res == testcases[i][1] ? "PASSED" : "FAILED");
        }
    }
}
