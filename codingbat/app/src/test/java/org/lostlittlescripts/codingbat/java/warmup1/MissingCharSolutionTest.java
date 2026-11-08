package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class MissingCharSolutionTest {

    @Test
    public void testMissingChar() {
        MissingCharSolution solution = new MissingCharSolution();

        assertEquals("ktten", solution.missingChar("kitten", 1));
        assertEquals("itten", solution.missingChar("kitten", 0));
        assertEquals("kittn", solution.missingChar("kitten", 4));
        assertEquals("i", solution.missingChar("Hi", 0));
        assertEquals("H", solution.missingChar("Hi", 1));
        assertEquals("ode", solution.missingChar("code", 0));
        assertEquals("cde", solution.missingChar("code", 1));
        assertEquals("coe", solution.missingChar("code", 2));
        assertEquals("cod", solution.missingChar("code", 3));
        assertEquals("chocolat", solution.missingChar("chocolate", 8));
    }
}
