package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class FrontBackSolutionTest {
    @Test
    public void testFrontBackSolution() {
        FrontBackSolution solution = new FrontBackSolution();

        assertEquals("eodc", solution.frontBack("code"));
        assertEquals("a", solution.frontBack("a"));
        assertEquals("ba", solution.frontBack("ab"));
        assertEquals("cba", solution.frontBack("abc"));
        assertEquals("", solution.frontBack(""));
        assertEquals("ehocolatC", solution.frontBack("Chocolate"));
        assertEquals("Java", solution.frontBack("aavJ"));
        assertEquals("oellh", solution.frontBack("hello"));
    }
}