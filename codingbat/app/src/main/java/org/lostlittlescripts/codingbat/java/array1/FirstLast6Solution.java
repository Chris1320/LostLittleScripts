/**
 * Given an array of ints, return true if 6 appears as either the
 * first or last element in the array. The array will be length 1 or more.
 * <p>
 * firstLast6([1, 2, 6]) → true
 * firstLast6([6, 1, 2, 3]) → true
 * firstLast6([13, 6, 1, 2, 3]) → false
 */

package org.lostlittlescripts.codingbat.java.array1;

public class FirstLast6Solution {
    public boolean firstLast6(int[] nums) {
        if (nums.length < 1) return false;
        return nums[0] == 6 || nums[nums.length - 1] == 6;
    }
}
