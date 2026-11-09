package org.lostlittlescripts.codingbat.java.warmup1;

import org.junit.Assert;
import org.junit.Test;

public class IcyHotSolutionTest {
    @Test
    public void testIcyHotSolution() {
        IcyHotSolution solution = new IcyHotSolution();

        Assert.assertTrue(solution.icyHot(120, -1));
        Assert.assertTrue(solution.icyHot(-1, 120));
        Assert.assertFalse(solution.icyHot(2, 120));
        Assert.assertFalse(solution.icyHot(-1, 100));
        Assert.assertFalse(solution.icyHot(-2, -2));
        Assert.assertFalse(solution.icyHot(120, 120));
    }
}
