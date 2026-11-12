package org.lostlittlescripts.codingbat.java.string1;

import org.junit.Test;
import org.junit.Assert;

public class MakeOutWordSolutionTest {
    @Test
    public void testMakeOutWordSolution() {
        MakeOutWordSolution solution = new MakeOutWordSolution();
        Assert.assertEquals("<<Yay>>", solution.makeOutWord("<<>>", "Yay"));
        Assert.assertEquals("<<WooHoo>>", solution.makeOutWord("<<>>", "WooHoo"));
        Assert.assertEquals("[[word]]", solution.makeOutWord("[[]]", "word"));
        Assert.assertEquals("HHHellooo", solution.makeOutWord("HHoo", "Hello"));
        Assert.assertEquals("abYAYyz", solution.makeOutWord("abyz", "YAY"));
    }
}
