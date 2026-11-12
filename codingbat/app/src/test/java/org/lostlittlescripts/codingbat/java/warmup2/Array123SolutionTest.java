package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class Array123SolutionTest {
    @Test
    public void testArray123Solution() {
        Array123Solution solution = new Array123Solution();

        Assert.assertTrue(solution.array123(new int[]{1, 1, 2, 3, 1}));
        Assert.assertFalse(solution.array123(new int[]{1, 1, 2, 4, 1}));
        Assert.assertTrue(solution.array123(new int[]{1, 1, 2, 1, 2, 3}));
        Assert.assertFalse(solution.array123(new int[]{1, 1, 2, 1, 2, 1}));
        Assert.assertTrue(solution.array123(new int[]{1, 2, 3, 1, 2, 3}));
        Assert.assertTrue(solution.array123(new int[]{1, 2, 3}));
        Assert.assertFalse(solution.array123(new int[]{1, 1, 1}));
        Assert.assertFalse(solution.array123(new int[]{1, 2}));
        Assert.assertFalse(solution.array123(new int[]{1}));
        Assert.assertFalse(solution.array123(new int[]{}));
    }
}
