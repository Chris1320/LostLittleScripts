/**
 * Given an array of ints length 3, figure out which is larger,
 * the first or last element in the array, and set all the other
 * elements to be that value. Return the changed array.
 * <p>
 * maxEnd3([1, 2, 3]) → [3, 3, 3]
 * maxEnd3([11, 5, 9]) → [11, 11, 11]
 * maxEnd3([2, 11, 3]) → [3, 3, 3]
 */

package org.lostlittlescripts.codingbat.java.array1;

import java.util.Arrays;

public class MaxEnd3Solution {
    public int[] maxEnd3(int[] nums) {
        int max = Math.max(nums[0], nums[nums.length - 1]);
        Arrays.fill(nums, max);
        return nums;
    }
}
