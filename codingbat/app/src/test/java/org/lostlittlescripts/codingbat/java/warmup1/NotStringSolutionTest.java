package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class NotStringSolutionTest {
    @Test
    public void testNotStringSolution() {
        var classUnderTest = new NotStringSolution();

        assertEquals("not candy", classUnderTest.notString("candy"));
        assertEquals("not x", classUnderTest.notString("x"));
        assertEquals("not bad", classUnderTest.notString("not bad"));
        assertEquals("not bad", classUnderTest.notString("bad"));
        assertEquals("not", classUnderTest.notString("not"));
        assertEquals("not is not", classUnderTest.notString("is not"));
        assertEquals("not no", classUnderTest.notString("no"));
    }
}
