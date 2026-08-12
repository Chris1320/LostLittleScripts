import java.util.List;
import java.util.Arrays;
import java.util.ArrayList;

class TestCase {
    public final int[] prices;
    public final int expected;

    public TestCase(int[] prices, int expected) {
        this.prices = prices;
        this.expected = expected;
    }
}

class Solution {
    public static int maxProfit(int[] prices) {
        // TODO: Solve this...
        return 0;
    }

    public static void main(String[] args) {
        List<TestCase> test_cases = new ArrayList<TestCase>() {
            {
                add(new TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5));
                add(new TestCase(new int[] { 7, 6, 4, 3, 1 }, 0));
                add(new TestCase(new int[] { 1, 2 }, 1));
                add(new TestCase(new int[] { 2, 4, 1 }, 2));
                add(new TestCase(new int[] { 100, 180, 260, 310, 40, 535, 695 }, 865));
            }
        };

        for (TestCase test_case : test_cases) {
            int result = maxProfit(test_case.prices);
            System.out.printf(
                    "%s == %d (expected: %d)\n",
                    Arrays.toString(test_case.prices),
                    result,
                    test_case.expected);
        }
    }
}
