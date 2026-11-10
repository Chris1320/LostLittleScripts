package org.lostlittlescripts.codingbat.java.warmup2;

import org.junit.Assert;
import org.junit.Test;

public class CountXXSolutionTest {
    @Test
    public void testCountXXSolution() {
        CountXXSolution solution = new CountXXSolution();
        Assert.assertEquals(1, solution.countXX("abcxx"));
        Assert.assertEquals(2, solution.countXX("xxx"));
        Assert.assertEquals(3, solution.countXX("xxxx"));
        Assert.assertEquals(0, solution.countXX("abc"));
        Assert.assertEquals(0, solution.countXX("Hello there"));
        Assert.assertEquals(2, solution.countXX("Hexxo thxxe"));
        Assert.assertEquals(0, solution.countXX(""));
        Assert.assertEquals(0, solution.countXX("Kittens"));
        Assert.assertEquals(2, solution.countXX("Kittensxxx"));
    }
}
