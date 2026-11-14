package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Assert;
import org.junit.Test;

public class CountEvensSolutionTest {
    @Test
    public void testCountEvensSolution() {
        CountEvensSolution solution = new CountEvensSolution();

        Assert.assertEquals(3, solution.countEvens(new int[]{2, 1, 2, 3, 4}));
        Assert.assertEquals(3, solution.countEvens(new int[]{2, 2, 0}));
        Assert.assertEquals(0, solution.countEvens(new int[]{1, 3, 5}));
        Assert.assertEquals(0, solution.countEvens(new int[]{}));
        Assert.assertEquals(1, solution.countEvens(new int[]{11, 9, 0, 1}));
        Assert.assertEquals(2, solution.countEvens(new int[]{2, 11, 9, 0}));
        Assert.assertEquals(1, solution.countEvens(new int[]{2}));
        Assert.assertEquals(2, solution.countEvens(new int[]{2, 5, 12}));
    }
}
