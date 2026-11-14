package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Assert;
import org.junit.Test;

public class FizzArraySolutionTest {
    @Test
    public void testFizzArraySolution() {

        FizzArraySolution fizzArraySolution = new FizzArraySolution();

        Assert.assertArrayEquals(new int[]{0, 1, 2, 3}, fizzArraySolution.fizzArray(4));
        Assert.assertArrayEquals(new int[]{0}, fizzArraySolution.fizzArray(1));
        Assert.assertArrayEquals(new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, fizzArraySolution.fizzArray(10));
        Assert.assertArrayEquals(new int[]{}, fizzArraySolution.fizzArray(0));
        Assert.assertArrayEquals(new int[]{0, 1}, fizzArraySolution.fizzArray(2));
        Assert.assertArrayEquals(new int[]{0, 1, 2, 3, 4, 5, 6}, fizzArraySolution.fizzArray(7));
    }
}
