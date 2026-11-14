package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class CommonEndSolutionTest {
    @Test
    public void testCommonEndSolution() {
        CommonEndSolution solution = new CommonEndSolution();

        Assert.assertTrue(solution.commonEnd(new int[]{1, 2, 3}, new int[]{7, 3}));
        Assert.assertFalse(solution.commonEnd(new int[]{1, 2, 3}, new int[]{7, 3, 2}));
        Assert.assertTrue(solution.commonEnd(new int[]{1, 2, 3}, new int[]{1, 3}));
        Assert.assertTrue(solution.commonEnd(new int[]{1, 2, 3}, new int[]{1}));
        Assert.assertFalse(solution.commonEnd(new int[]{1, 2, 3}, new int[]{2}));
    }
}
