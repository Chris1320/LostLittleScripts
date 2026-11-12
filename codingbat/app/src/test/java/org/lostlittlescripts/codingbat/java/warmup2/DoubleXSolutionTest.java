package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class DoubleXSolutionTest {
    @Test
    public void testDoubleXSolution() {
        DoubleXSolution solution = new DoubleXSolution();

        Assert.assertTrue(solution.doubleX("axxbb"));
        Assert.assertFalse(solution.doubleX("axaxax"));
        Assert.assertTrue(solution.doubleX("xxxxx"));
        Assert.assertFalse(solution.doubleX("xaxxx"));
        Assert.assertFalse(solution.doubleX("aaaax"));
        Assert.assertFalse(solution.doubleX(""));
        Assert.assertFalse(solution.doubleX("abc"));
        Assert.assertFalse(solution.doubleX("x"));
        Assert.assertTrue(solution.doubleX("xx"));
        Assert.assertFalse(solution.doubleX("xax"));
        Assert.assertFalse(solution.doubleX("xaxx"));
    }
}
