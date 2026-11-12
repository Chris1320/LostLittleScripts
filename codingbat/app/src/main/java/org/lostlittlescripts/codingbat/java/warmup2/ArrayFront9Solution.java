/**
 * Given an array of ints, return true if one of the first 4 elements in the array is a 9.
 * The array length may be less than 4.
 * <p>
 * arrayFront9([1, 2, 9, 3, 4]) → true
 * arrayFront9([1, 2, 3, 4, 9]) → false
 * arrayFront9([1, 2, 3, 4, 5]) → false
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class ArrayFront9Solution {
    public boolean arrayFront9(int[] nums) {
        for (int i = 0; i < Math.min(nums.length, 4); i++) {
            if (nums[i] == 9) return true;
        }
        return false;
    }
}
