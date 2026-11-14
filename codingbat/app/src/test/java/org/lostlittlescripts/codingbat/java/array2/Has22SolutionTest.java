package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Test;
import org.junit.Assert;

public class Has22SolutionTest {
    @Test
    public void testHas22Solution() {

        Has22Solution solution = new Has22Solution();

        Assert.assertTrue(solution.has22(new int[]{1, 2, 2}));
        Assert.assertFalse(solution.has22(new int[]{1, 2, 1, 2}));
        Assert.assertFalse(solution.has22(new int[]{2, 1, 2}));
        Assert.assertTrue(solution.has22(new int[]{2, 2, 1, 2}));
        Assert.assertFalse(solution.has22(new int[]{1, 3, 2}));
        Assert.assertTrue(solution.has22(new int[]{1, 3, 2, 2}));
        Assert.assertTrue(solution.has22(new int[]{2, 3, 2, 2}));
        Assert.assertTrue(solution.has22(new int[]{4, 2, 4, 2, 2, 5}));
        Assert.assertFalse(solution.has22(new int[]{1, 2}));
        Assert.assertTrue(solution.has22(new int[]{2, 2}));
        Assert.assertFalse(solution.has22(new int[]{2}));
        Assert.assertFalse(solution.has22(new int[]{}));
        Assert.assertTrue(solution.has22(new int[]{3, 3, 2, 2}));
        Assert.assertFalse(solution.has22(new int[]{5, 2, 5, 2}));
    }
}
