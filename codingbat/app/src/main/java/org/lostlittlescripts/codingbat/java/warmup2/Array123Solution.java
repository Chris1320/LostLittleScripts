/**
 * Given an array of ints, return true if the sequence of numbers
 * 1, 2, 3 appears in the array somewhere.
 * <p>
 * array123([1, 1, 2, 3, 1]) → true
 * array123([1, 1, 2, 4, 1]) → false
 * array123([1, 1, 2, 1, 2, 3]) → true
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class Array123Solution {
    public boolean array123(int[] nums) {
        int looking_for = 1;
        for (int num : nums) {
            if (num == looking_for) {
                if (looking_for == 3) return true;
                looking_for++;
            }
        }
        return false;
    }
}
