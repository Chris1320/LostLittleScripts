package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class Last2SolutionTest {
    @Test
    public void testLast2Solution() {
        Last2Solution solution = new Last2Solution();

        Assert.assertEquals(1, solution.last2("hixxhi"));
        Assert.assertEquals(1, solution.last2("xaxxaxaxx"));
        Assert.assertEquals(2, solution.last2("axxxaaxx"));
        Assert.assertEquals(3, solution.last2("xxaxxaxxaxx"));
        Assert.assertEquals(0, solution.last2("xaxaxaxx"));
        Assert.assertEquals(2, solution.last2("xxxx"));
        Assert.assertEquals(1, solution.last2("13121312"));
        Assert.assertEquals(1, solution.last2("11212"));
        Assert.assertEquals(0, solution.last2("13121311"));
        Assert.assertEquals(2, solution.last2("1717171"));
        Assert.assertEquals(0, solution.last2("hi"));
        Assert.assertEquals(0, solution.last2("h"));
        Assert.assertEquals(0, solution.last2(""));
    }
}
