package org.lostlittlescripts.codingbat.java.warmup1;

import org.junit.Assert;
import org.junit.Test;

public class Or35SolutionTest {
    @Test
    public void testOr35Solution() {
        Or35Solution solution = new Or35Solution();

        Assert.assertTrue(solution.or35(3));
        Assert.assertTrue(solution.or35(10));
        Assert.assertFalse(solution.or35(8));
        Assert.assertTrue(solution.or35(15));
        Assert.assertTrue(solution.or35(5));
        Assert.assertTrue(solution.or35(9));
        Assert.assertFalse(solution.or35(4));
        Assert.assertFalse(solution.or35(7));
        Assert.assertTrue(solution.or35(6));
        Assert.assertFalse(solution.or35(17));
        Assert.assertTrue(solution.or35(18));
        Assert.assertFalse(solution.or35(29));
        Assert.assertTrue(solution.or35(20));
        Assert.assertTrue(solution.or35(21));
        Assert.assertFalse(solution.or35(22));
        Assert.assertTrue(solution.or35(45));
        Assert.assertTrue(solution.or35(99));
        Assert.assertTrue(solution.or35(100));
        Assert.assertFalse(solution.or35(101));
        Assert.assertFalse(solution.or35(121));
        Assert.assertFalse(solution.or35(122));
        Assert.assertTrue(solution.or35(123));
        Assert.assertTrue(solution.or35(3));
    }
}
