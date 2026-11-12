/**
 * Given an array of ints, return the number of 9's in the array.
 *
 * arrayCount9([1, 2, 9]) → 1
 * arrayCount9([1, 9, 9]) → 2
 * arrayCount9([1, 9, 9, 3, 9]) → 3
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class ArrayCount9Solution {
    public int arrayCount9(int[] nums) {
        int total = 0;
        for (int num : nums) {
            if (num == 9) total++;
        }
        return total;
    }
}
