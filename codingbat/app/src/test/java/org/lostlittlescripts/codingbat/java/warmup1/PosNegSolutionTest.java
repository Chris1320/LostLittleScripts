package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertTrue;
import static org.junit.Assert.assertFalse;

import org.junit.Test;

public class PosNegSolutionTest {

    @Test
    public void testPosNegSolution() {
        var classUnderTest = new PosNegSolution();

        assertTrue(classUnderTest.posNeg(1, -1, false));
        assertTrue(classUnderTest.posNeg(-1, 1, false));
        assertTrue(classUnderTest.posNeg(-4, -5, true));
        assertFalse(classUnderTest.posNeg(-4, -5, false));
        assertTrue(classUnderTest.posNeg(-4, 5, false));
        assertFalse(classUnderTest.posNeg(-4, 5, true));
        assertFalse(classUnderTest.posNeg(1, 1, false));
        assertFalse(classUnderTest.posNeg(-1, -1, false));
        assertFalse(classUnderTest.posNeg(1, -1, true));
        assertFalse(classUnderTest.posNeg(-1, 1, true));
        assertFalse(classUnderTest.posNeg(1, 1, true));
        assertTrue(classUnderTest.posNeg(-1, -1, true));
        assertTrue(classUnderTest.posNeg(5, -5, false));
        assertTrue(classUnderTest.posNeg(-6, 6, false));
        assertFalse(classUnderTest.posNeg(-5, -6, false));
        assertFalse(classUnderTest.posNeg(-2, -1, false));
        assertFalse(classUnderTest.posNeg(1, 2, false));
        assertFalse(classUnderTest.posNeg(-5, 6, true));
        assertTrue(classUnderTest.posNeg(-5, -5, true));
    }
}
