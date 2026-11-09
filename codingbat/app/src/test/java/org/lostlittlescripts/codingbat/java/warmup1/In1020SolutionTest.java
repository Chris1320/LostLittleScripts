package org.lostlittlescripts.codingbat.java.warmup1;

import org.junit.Assert;
import org.junit.Test;

public class In1020SolutionTest {
    @Test
    public void testIn1020Solution() {
        In1020Solution solution = new In1020Solution();
        Assert.assertTrue(solution.in1020(12, 99));
        Assert.assertTrue(solution.in1020(21, 12));
        Assert.assertFalse(solution.in1020(8, 99));
        Assert.assertTrue(solution.in1020(99, 10));
        Assert.assertTrue(solution.in1020(20, 20));
        Assert.assertFalse(solution.in1020(21, 21));
        Assert.assertFalse(solution.in1020(9, 9));
    }
}
