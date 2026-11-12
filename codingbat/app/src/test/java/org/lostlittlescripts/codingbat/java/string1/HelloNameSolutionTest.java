package org.lostlittlescripts.codingbat.java.string1;

import org.junit.Assert;
import org.junit.Test;

public class HelloNameSolutionTest {
    @Test
    public void testHelloNameSolution() {
        HelloNameSolution solution = new HelloNameSolution();

        Assert.assertEquals("Hello Bob!", solution.helloName("Bob"));
        Assert.assertEquals("Hello Alice!", solution.helloName("Alice"));
        Assert.assertEquals("Hello X!", solution.helloName("X"));
        Assert.assertEquals("Hello Dolly!", solution.helloName("Dolly"));
        Assert.assertEquals("Hello Alpha!", solution.helloName("Alpha"));
        Assert.assertEquals("Hello Omega!", solution.helloName("Omega"));
        Assert.assertEquals("Hello Goodbye!", solution.helloName("Goodbye"));
        Assert.assertEquals("Hello ho ho ho!", solution.helloName("ho ho ho"));
        Assert.assertEquals("Hello xyz!!", solution.helloName("xyz!"));
        Assert.assertEquals("Hello Hello!", solution.helloName("Hello"));
    }
}
