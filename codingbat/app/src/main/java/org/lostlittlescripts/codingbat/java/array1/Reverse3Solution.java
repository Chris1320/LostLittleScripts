/**
 * Given an array of ints length 3, return a new array with the
 * elements in reverse order, so {1, 2, 3} becomes {3, 2, 1}.
 * <p>
 * reverse3([1, 2, 3]) → [3, 2, 1]
 * reverse3([5, 11, 9]) → [9, 11, 5]
 * reverse3([7, 0, 0]) → [0, 0, 7]
 */

package org.lostlittlescripts.codingbat.java.array1;

public class Reverse3Solution {
    public int[] reverse3(int[] nums) {
        int[] result = new int[nums.length];
        for (int i = nums.length - 1; i >= 0; i--)
            result[result.length - 1 - i] = nums[i];
        return result;
    }
}
