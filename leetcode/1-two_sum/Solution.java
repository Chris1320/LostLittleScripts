import java.util.Arrays;

class Solution {
    public static void main(String[] args) {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        System.out.printf(
            "Input: nums = %s, target = %s\n",
            Arrays.toString(nums),
            target
        );

        int[] result = twoSum(nums, target);

        System.out.println("result: " + Arrays.toString(result));
    }
    public static int[] twoSum(int[] nums, int target) {
        for (int x = 0; x < nums.length; x++) {
            for (int y = x + 1; y < nums.length; y++) {
                if (nums[x] + nums[y] == target) {
                    return new int[] {x, y};
                }
            }
        }
        return new int[] {};  // Return an empty array if none is found.
    }
}
