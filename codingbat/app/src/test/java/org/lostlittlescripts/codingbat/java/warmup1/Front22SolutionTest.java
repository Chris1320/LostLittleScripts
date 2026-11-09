package org.lostlittlescripts.codingbat.java.warmup1;

import org.junit.Test;
import org.junit.Assert;

public class Front22SolutionTest {
    @Test
    public void testFront22Solution() {
        Front22Solution solution = new Front22Solution();

        Assert.assertEquals("kikittenki", solution.front22("kitten"));
        Assert.assertEquals("HaHaHa", solution.front22("Ha"));
        Assert.assertEquals("ababcab", solution.front22("abc"));
        Assert.assertEquals("ababab", solution.front22("ab"));
        Assert.assertEquals("aaa", solution.front22("a"));
        Assert.assertEquals("", solution.front22(""));
        Assert.assertEquals("LoLogicLo", solution.front22("Logic"));
    }
}
