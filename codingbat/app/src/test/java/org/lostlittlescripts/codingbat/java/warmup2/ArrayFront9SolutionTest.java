package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class ArrayFront9SolutionTest {
    @Test
    public void testArrayFront9Solution() {
        ArrayFront9Solution solution = new ArrayFront9Solution();

        Assert.assertTrue(solution.arrayFront9(new int[]{1, 2, 9, 3, 4}));
        Assert.assertFalse(solution.arrayFront9(new int[]{1, 2, 3, 4, 9}));
        Assert.assertFalse(solution.arrayFront9(new int[]{1, 2, 3, 4, 5}));
        Assert.assertTrue(solution.arrayFront9(new int[]{9, 2, 3}));
        Assert.assertTrue(solution.arrayFront9(new int[]{1, 9, 9}));
        Assert.assertFalse(solution.arrayFront9(new int[]{1, 2, 3}));
        Assert.assertTrue(solution.arrayFront9(new int[]{1, 9}));
        Assert.assertFalse(solution.arrayFront9(new int[]{5, 5}));
        Assert.assertFalse(solution.arrayFront9(new int[]{2}));
        Assert.assertTrue(solution.arrayFront9(new int[]{9}));
        Assert.assertFalse(solution.arrayFront9(new int[]{}));
        Assert.assertTrue(solution.arrayFront9(new int[]{3, 9, 2, 3, 3}));
    }
}
