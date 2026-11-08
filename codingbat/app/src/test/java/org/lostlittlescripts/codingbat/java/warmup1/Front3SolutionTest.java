package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class Front3SolutionTest {
    @Test
    public void testFront3Solution() {
        Front3Solution solution = new Front3Solution();
        assertEquals("JavJavJav", solution.front3("Java"));
        assertEquals("ChoChoCho", solution.front3("Chocolate"));
        assertEquals("abcabcabc", solution.front3("abc"));
        assertEquals("abcabcabc", solution.front3("abcXYZ"));
        assertEquals("ababab", solution.front3("ab"));
        assertEquals("aaa", solution.front3("a"));
        assertEquals("", solution.front3(""));
    }
}
