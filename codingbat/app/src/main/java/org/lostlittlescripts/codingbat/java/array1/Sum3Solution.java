/**
 * Given an array of ints length 3, return the sum of all the elements.
 * <p>
 * sum3([1, 2, 3]) → 6
 * sum3([5, 11, 2]) → 18
 * sum3([7, 0, 0]) → 7
 */

package org.lostlittlescripts.codingbat.java.array1;

import java.util.Collections;

public class Sum3Solution {
    public int sum3(int[] nums) {
        int result = 0;
        for (int num : nums) result += num;
        return result;
    }
}
