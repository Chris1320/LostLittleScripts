package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Assert;
import org.junit.Test;

public class BigDiffSolutionTest {
    @Test
    public void testBigDiffSolution() {
        BigDiffSolution solution = new BigDiffSolution();

        Assert.assertEquals(7, solution.bigDiff(new int[]{10, 3, 5, 6}));
        Assert.assertEquals(8, solution.bigDiff(new int[]{7, 2, 10, 9}));
        Assert.assertEquals(8, solution.bigDiff(new int[]{2, 10, 7, 2}));
        Assert.assertEquals(8, solution.bigDiff(new int[]{2, 10}));
        Assert.assertEquals(8, solution.bigDiff(new int[]{10, 2}));
        Assert.assertEquals(10, solution.bigDiff(new int[]{10, 0}));
        Assert.assertEquals(1, solution.bigDiff(new int[]{2, 3}));
        Assert.assertEquals(0, solution.bigDiff(new int[]{2, 2}));
        Assert.assertEquals(0, solution.bigDiff(new int[]{2}));
        Assert.assertEquals(8, solution.bigDiff(new int[]{5, 1, 6, 1, 9, 9}));
        Assert.assertEquals(3, solution.bigDiff(new int[]{7, 6, 8, 5}));
        Assert.assertEquals(3, solution.bigDiff(new int[]{7, 7, 6, 8, 5, 5, 6}));
    }
}
