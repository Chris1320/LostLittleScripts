/**
 * Return the number of even ints in the given array.
 * Note: the % "mod" operator computes the remainder, e.g. 5 % 2 is 1.
 * <p>
 * countEvens([2, 1, 2, 3, 4]) → 3
 * countEvens([2, 2, 0]) → 3
 * countEvens([1, 3, 5]) → 0
 */

package org.lostlittlescripts.codingbat.java.array2;

public class CountEvensSolution {
    public int countEvens(int[] nums) {
        int total = 0;
        for (int num : nums)
            total += num % 2 == 0 ? 1 : 0;
        return total;
    }
}
