package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class StringSplosionSolutionTest {
    @Test
    public void testStringSplosionSolution() {
        StringSplosionSolution solution = new StringSplosionSolution();

        Assert.assertEquals("CCoCodCode", solution.stringSplosion("Code"));
        Assert.assertEquals("aababc", solution.stringSplosion("abc"));
        Assert.assertEquals("aab", solution.stringSplosion("ab"));
        Assert.assertEquals("x", solution.stringSplosion("x"));
        Assert.assertEquals("ffafadfade", solution.stringSplosion("fade"));
        Assert.assertEquals("TThTheTherThere", solution.stringSplosion("There"));
        Assert.assertEquals("KKiKitKittKitteKitten", solution.stringSplosion("Kitten"));
        Assert.assertEquals("BByBye", solution.stringSplosion("Bye"));
        Assert.assertEquals("GGoGooGood", solution.stringSplosion("Good"));
        Assert.assertEquals("BBaBad", solution.stringSplosion("Bad"));
    }
}
