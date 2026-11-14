package org.lostlittlescripts.codingbat.java.string1;

import org.junit.Assert;
import org.junit.Test;

public class ExtraEndSolutionTest {
    @Test
    public void testExtraEndSolution() {
        ExtraEndSolution solution = new ExtraEndSolution();

        Assert.assertEquals("lololo", solution.extraEnd("Hello"));
        Assert.assertEquals("ababab", solution.extraEnd("ab"));
        Assert.assertEquals("HiHiHi", solution.extraEnd("Hi"));
        Assert.assertEquals("dydydy", solution.extraEnd("Candy"));
        Assert.assertEquals("dedede", solution.extraEnd("Code"));
    }
}
