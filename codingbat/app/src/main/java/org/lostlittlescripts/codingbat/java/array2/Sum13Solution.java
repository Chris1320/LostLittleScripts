/**
 * Return the sum of the numbers in the array, returning 0 for an
 * empty array. Except the number 13 is very unlucky, so it does
 * not count and numbers that come immediately after a 13 also do
 * not count.
 * <p>
 * sum13([1, 2, 2, 1]) → 6
 * sum13([1, 1]) → 2
 * sum13([1, 2, 2, 1, 13]) → 6
 */

package org.lostlittlescripts.codingbat.java.array2;

public class Sum13Solution {
    public int sum13(int[] nums) {
        int result = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == 13) {
                i++;
                continue;
            }
            result += nums[i];
        }
        return result;
    }
}
