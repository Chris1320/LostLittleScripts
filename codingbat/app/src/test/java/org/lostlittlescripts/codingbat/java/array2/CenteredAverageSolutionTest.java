package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Assert;
import org.junit.Test;

public class CenteredAverageSolutionTest {
    @Test
    public void testCenteredAverageSolution() {
        CenteredAverageSolution solution = new CenteredAverageSolution();

        Assert.assertEquals(3, solution.centeredAverage(new int[]{1, 2, 3, 4, 100}));
        Assert.assertEquals(5, solution.centeredAverage(new int[]{1, 1, 5, 5, 10, 8, 7}));
        Assert.assertEquals(-3, solution.centeredAverage(new int[]{-10, -4, -2, -4, -2, 0}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{5, 3, 4, 6, 2}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{5, 3, 4, 0, 100}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{100, 0, 5, 3, 4}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{4, 0, 100}));
        Assert.assertEquals(3, solution.centeredAverage(new int[]{0, 2, 3, 4, 100}));
        Assert.assertEquals(1, solution.centeredAverage(new int[]{1, 1, 100}));
        Assert.assertEquals(7, solution.centeredAverage(new int[]{7, 7, 7}));
        Assert.assertEquals(7, solution.centeredAverage(new int[]{1, 7, 8}));
        Assert.assertEquals(50, solution.centeredAverage(new int[]{1, 1, 99, 99}));
        Assert.assertEquals(50, solution.centeredAverage(new int[]{1000, 0, 1, 99}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{4, 4, 4, 4, 5}));
        Assert.assertEquals(4, solution.centeredAverage(new int[]{4, 4, 4, 1, 5}));
        Assert.assertEquals(6, solution.centeredAverage(new int[]{6, 4, 8, 12, 3}));
    }
}
