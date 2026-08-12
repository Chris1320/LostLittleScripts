import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.stream.Collectors;

class TestCase {
    public final int[] nums;
    public final int expected;

    public TestCase(int[] nums, int expected) {
        this.nums = nums;
        this.expected = expected;
    }
}

class Solution {
    public static int missingInteger(int[] nums) {
        int result = nums[0];

        for (int i = 0; i < nums.length; i++) {
            if (i + 1 >= nums.length)
                break;
            if (nums[i + 1] == nums[i] + 1) {
                result += nums[i + 1];
            } else
                break;
        }
        var nums_set = new HashSet<>(Arrays.stream(nums).boxed().collect(Collectors.toList()));
        while (nums_set.contains(result)) {
            result++;
        }
        return result;
    }

    public static void main(String[] args) {
        var test_cases = new ArrayList<TestCase>();
        test_cases.add(new TestCase(new int[] { 1, 2, 3, 2, 5 }, 6));
        test_cases.add(new TestCase(new int[] { 3, 4, 5, 1, 12, 14, 13 }, 15));
        test_cases.add(new TestCase(new int[] { 3, 4, 5, 7, 9, 8, 1, 3, 4, 9 }, 12));
        test_cases.add(new TestCase(new int[] { 14, 9, 6, 9, 7, 9, 10, 4, 9, 9, 4, 4 }, 15));

        int success = 0;
        for (int i = 0; i < test_cases.size(); i++) {
            var result = Solution.missingInteger(test_cases.get(i).nums);
            System.out.printf(
                    "%s == %d (expected: %d)\n",
                    Arrays.toString(test_cases.get(i).nums),
                    result,
                    test_cases.get(i).expected);
            if (test_cases.get(i).expected == result)
                success++;
        }
        System.out.printf("%d out of %d test cases are correct\n", success, test_cases.size());
        return;
    }
}
