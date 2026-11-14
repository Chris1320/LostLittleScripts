package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Assert;
import org.junit.Test;

public class Sum13SolutionTest {
    @Test
    public void testSum13Solution() {
        Sum13Solution solution = new Sum13Solution();

        Assert.assertEquals(6, solution.sum13(new int[]{1, 2, 2, 1}));
        Assert.assertEquals(2, solution.sum13(new int[]{1, 1}));
        Assert.assertEquals(6, solution.sum13(new int[]{1, 2, 2, 1, 13}));
        Assert.assertEquals(4, solution.sum13(new int[]{1, 2, 13, 2, 1, 13}));
        Assert.assertEquals(3, solution.sum13(new int[]{13, 1, 2, 13, 2, 1, 13}));
        Assert.assertEquals(0, solution.sum13(new int[]{}));
        Assert.assertEquals(0, solution.sum13(new int[]{13}));
        Assert.assertEquals(0, solution.sum13(new int[]{13, 13}));
        Assert.assertEquals(0, solution.sum13(new int[]{13, 0, 13}));
        Assert.assertEquals(0, solution.sum13(new int[]{13, 1, 13}));
        Assert.assertEquals(14, solution.sum13(new int[]{5, 7, 2}));
        Assert.assertEquals(5, solution.sum13(new int[]{5, 13, 2}));
        Assert.assertEquals(0, solution.sum13(new int[]{0}));
        Assert.assertEquals(0, solution.sum13(new int[]{13, 0}));
    }
}
