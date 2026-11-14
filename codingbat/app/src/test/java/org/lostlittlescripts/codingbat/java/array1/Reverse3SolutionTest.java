package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class Reverse3SolutionTest {
    @Test
    public void testReverse3Solution() {
        Reverse3Solution solution = new Reverse3Solution();

        Assert.assertArrayEquals(new int[]{3, 2, 1}, solution.reverse3(new int[]{1, 2, 3}));
        Assert.assertArrayEquals(new int[]{9, 11, 5}, solution.reverse3(new int[]{5, 11, 9}));
        Assert.assertArrayEquals(new int[]{0, 0, 7}, solution.reverse3(new int[]{7, 0, 0}));
        Assert.assertArrayEquals(new int[]{2, 1, 2}, solution.reverse3(new int[]{2, 1, 2}));
        Assert.assertArrayEquals(new int[]{1, 2, 1}, solution.reverse3(new int[]{1, 2, 1}));
        Assert.assertArrayEquals(new int[]{3, 11, 2}, solution.reverse3(new int[]{2, 11, 3}));
        Assert.assertArrayEquals(new int[]{5, 6, 0}, solution.reverse3(new int[]{0, 6, 5}));
        Assert.assertArrayEquals(new int[]{3, 2, 7}, solution.reverse3(new int[]{7, 2, 3}));
    }
}
