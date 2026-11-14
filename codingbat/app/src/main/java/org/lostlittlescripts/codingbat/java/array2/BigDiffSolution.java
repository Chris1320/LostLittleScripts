/**
 * Given an array length 1 or more of ints, return the difference between the
 * largest and smallest values in the array.
 * <p>
 * Note: the built-in Math.min(v1, v2) and Math.max(v1, v2) methods return
 * the smaller or larger of two values.
 * <p>
 * bigDiff([10, 3, 5, 6]) → 7
 * bigDiff([7, 2, 10, 9]) → 8
 * bigDiff([2, 10, 7, 2]) → 8
 */

package org.lostlittlescripts.codingbat.java.array2;

public class BigDiffSolution {
    public int bigDiff(int[] nums) {
        int min = Integer.MAX_VALUE, max = Integer.MIN_VALUE;
        for (int num : nums) {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return Math.abs(min - max);
    }
}
