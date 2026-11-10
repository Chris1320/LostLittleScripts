package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class StringTimesSolutionTest {
    @Test
    public void testStringTimesSolution() {
        StringTimesSolution solution = new StringTimesSolution();
        Assert.assertEquals("HiHi", solution.stringTimes("Hi", 2));
        Assert.assertEquals("HiHiHi", solution.stringTimes("Hi", 3));
        Assert.assertEquals("Hi", solution.stringTimes("Hi", 1));
        Assert.assertEquals("", solution.stringTimes("Hi", 0));
        Assert.assertEquals("HiHiHiHiHi", solution.stringTimes("Hi", 5));
        Assert.assertEquals("Oh Boy!Oh Boy!", solution.stringTimes("Oh Boy!", 2));
        Assert.assertEquals("xxxx", solution.stringTimes("x", 4));
        Assert.assertEquals("", solution.stringTimes("", 4));
        Assert.assertEquals("codecode", solution.stringTimes("code", 2));
        Assert.assertEquals("codecodecode", solution.stringTimes("code", 3));
    }
}
