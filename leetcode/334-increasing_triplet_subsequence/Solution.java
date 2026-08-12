import java.util.List;
import java.util.Arrays;
import java.util.ArrayList;

class TestCase {
    public final int[] nums;
    public final boolean expected;

    public TestCase(int[] nums, boolean expected) {
        this.nums = nums;
        this.expected = expected;
    }
}

class Solution {
    public static boolean increasingTriplet(int[] nums) {
        int lowest = Integer.MAX_VALUE;
        int lower = Integer.MAX_VALUE;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] < lowest) {
                lowest = nums[i];
            } else if (nums[i] > lowest && nums[i] < lower) {
                lower = nums[i];
            } else if (lowest < lower && lower < nums[i]) {
                // System.out.printf("%d %d %d\n", lowest, lower, nums[i]);
                return true;
            }
        }
        return false;
    }

    public static void main(String[] args) {
        List<TestCase> test_cases = new ArrayList<TestCase>() {
            {
                add(new TestCase(new int[] { 1, 2, 3, 4, 5 }, true));
                add(new TestCase(new int[] { 5, 4, 3, 2, 1 }, false));
                add(new TestCase(new int[] { 2, 1, 5, 0, 4, 6 }, true));
                add(new TestCase(new int[] { 1, 1, -2, 6 }, false));
            }
        };

        for (TestCase test_case : test_cases) {
            boolean result = Solution.increasingTriplet(test_case.nums);
            System.out.printf(
                    "%s == %b (expected: %b)\n",
                    Arrays.toString(test_case.nums),
                    result,
                    test_case.expected);
        }
    }
}
