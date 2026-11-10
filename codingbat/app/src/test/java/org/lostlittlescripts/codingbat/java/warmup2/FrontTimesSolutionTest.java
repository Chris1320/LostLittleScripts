package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class FrontTimesSolutionTest {
    @Test
    public void testFrontTimesSolution() {
        FrontTimesSolution solution = new FrontTimesSolution();
        Assert.assertEquals("ChoCho", solution.frontTimes("Chocolate", 2));
        Assert.assertEquals("ChoChoCho", solution.frontTimes("Chocolate", 3));
        Assert.assertEquals("AbcAbcAbc", solution.frontTimes("Abc", 3));
        Assert.assertEquals("AbAbAbAb", solution.frontTimes("Ab", 4));
        Assert.assertEquals("AAAA", solution.frontTimes("A", 4));
        Assert.assertEquals("", solution.frontTimes("", 4));
        Assert.assertEquals("", solution.frontTimes("Abc", 0));
    }
}
