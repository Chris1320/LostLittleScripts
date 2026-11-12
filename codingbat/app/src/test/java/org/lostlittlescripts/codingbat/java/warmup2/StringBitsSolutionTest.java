package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class StringBitsSolutionTest {
    @Test
    public void testStringBitsSolution() {
        StringBitsSolution solution = new StringBitsSolution();

        Assert.assertEquals("Hlo", solution.stringBits("Hello"));
        Assert.assertEquals("H", solution.stringBits("Hi"));
        Assert.assertEquals("Hello", solution.stringBits("Heeololeo"));
        Assert.assertEquals("HHH", solution.stringBits("HiHiHi"));
        Assert.assertEquals("", solution.stringBits(""));
        Assert.assertEquals("Getns", solution.stringBits("Greetings"));
        Assert.assertEquals("Coot", solution.stringBits("Chocoate"));
        Assert.assertEquals("p", solution.stringBits("pi"));
        Assert.assertEquals("HloKte", solution.stringBits("Hello Kitten"));
        Assert.assertEquals("happy", solution.stringBits("hxaxpxpxy"));
    }
}
