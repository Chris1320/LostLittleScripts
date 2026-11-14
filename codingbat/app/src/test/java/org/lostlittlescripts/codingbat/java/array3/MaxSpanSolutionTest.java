package org.lostlittlescripts.codingbat.java.array3;

import org.junit.Assert;
import org.junit.Test;

public class MaxSpanSolutionTest {
    @Test
    public void testMaxSpanSolution() {
        MaxSpanSolution solution = new MaxSpanSolution();

        Assert.assertEquals(4, solution.maxSpan(new int[] { 1, 2, 1, 1, 3 }));
        Assert.assertEquals(6, solution.maxSpan(new int[] { 1, 4, 2, 1, 4, 1, 4 }));
        Assert.assertEquals(6, solution.maxSpan(new int[] { 1, 4, 2, 1, 4, 4, 4 }));
    }
}
