package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class BackAroundSolutionTest {
    @Test
    public void testBackAroundSolution() {
        assertEquals("tcatt", new BackAroundSolution().backAround("cat"));
        assertEquals("oHelloo", new BackAroundSolution().backAround("Hello"));
        assertEquals("aaa", new BackAroundSolution().backAround("a"));
        assertEquals("cabcc", new BackAroundSolution().backAround("abc"));
        assertEquals("dreadd", new BackAroundSolution().backAround("read"));
        assertEquals("obooo", new BackAroundSolution().backAround("boo"));
    }
}
