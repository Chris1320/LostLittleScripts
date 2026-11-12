package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class ArrayCount9SolutionTest {
    @Test
    public void testArrayCount9Solution() {
        ArrayCount9Solution solution = new ArrayCount9Solution();

        Assert.assertEquals(1, solution.arrayCount9(new int[]{1, 2, 9}));
        Assert.assertEquals(2, solution.arrayCount9(new int[]{1, 9, 9}));
        Assert.assertEquals(3, solution.arrayCount9(new int[]{1, 9, 9, 3, 9}));
        Assert.assertEquals(0, solution.arrayCount9(new int[]{1, 2, 3}));
        Assert.assertEquals(0, solution.arrayCount9(new int[]{}));
        Assert.assertEquals(0, solution.arrayCount9(new int[]{4, 2, 4, 3, 1}));
        Assert.assertEquals(1, solution.arrayCount9(new int[]{9, 2, 4, 3, 1}));
    }
}
