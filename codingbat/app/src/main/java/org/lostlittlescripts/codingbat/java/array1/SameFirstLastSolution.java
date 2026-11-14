/**
 * Given an array of ints, return true if the array is length 1 or more,
 * and the first element and the last element are equal.
 * <p>
 * sameFirstLast([1, 2, 3]) → false
 * sameFirstLast([1, 2, 3, 1]) → true
 * sameFirstLast([1, 2, 1]) → true
 */

package org.lostlittlescripts.codingbat.java.array1;

public class SameFirstLastSolution {
    public boolean sameFirstLast(int[] nums) {
        if (nums.length < 1) return false;
        return nums[0] == nums[nums.length - 1];
    }
}
