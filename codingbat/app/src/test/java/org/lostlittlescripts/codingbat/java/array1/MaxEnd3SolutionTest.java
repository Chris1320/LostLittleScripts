package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class MaxEnd3SolutionTest {
    @Test
    public void testMaxEnd3Solution() {
        MaxEnd3Solution solution = new MaxEnd3Solution();

        Assert.assertArrayEquals(new int[]{3, 3, 3}, solution.maxEnd3(new int[]{1, 2, 3}));
        Assert.assertArrayEquals(new int[]{11, 11, 11}, solution.maxEnd3(new int[]{11, 5, 9}));
        Assert.assertArrayEquals(new int[]{3, 3, 3}, solution.maxEnd3(new int[]{2, 11, 3}));
        Assert.assertArrayEquals(new int[]{11, 11, 11}, solution.maxEnd3(new int[]{11, 3, 3}));
        Assert.assertArrayEquals(new int[]{11, 11, 11}, solution.maxEnd3(new int[]{3, 11, 11}));
        Assert.assertArrayEquals(new int[]{2, 2, 2}, solution.maxEnd3(new int[]{2, 2, 2}));
        Assert.assertArrayEquals(new int[]{2, 2, 2}, solution.maxEnd3(new int[]{2, 11, 2}));
        Assert.assertArrayEquals(new int[]{1, 1, 1}, solution.maxEnd3(new int[]{0, 0, 1}));
    }
}
