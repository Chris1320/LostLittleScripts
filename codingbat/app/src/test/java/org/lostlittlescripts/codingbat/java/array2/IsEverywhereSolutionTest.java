package org.lostlittlescripts.codingbat.java.array2;

import org.junit.Test;
import org.junit.Assert;

public class IsEverywhereSolutionTest {
    @Test
    public void testIsEverywhereSolution() {
        IsEverywhereSolution solution = new IsEverywhereSolution();

        Assert.assertTrue(solution.isEverywhere(new int[]{1, 2, 1, 3}, 1));
        Assert.assertFalse(solution.isEverywhere(new int[]{1, 2, 1, 3}, 2));
        Assert.assertFalse(solution.isEverywhere(new int[]{1, 2, 1, 3, 4}, 1));
        Assert.assertTrue(solution.isEverywhere(new int[]{2, 1, 2, 1}, 1));
        Assert.assertTrue(solution.isEverywhere(new int[]{2, 1, 2, 1}, 2));
        Assert.assertFalse(solution.isEverywhere(new int[]{2, 1, 2, 3, 1}, 2));
        Assert.assertTrue(solution.isEverywhere(new int[]{3, 1}, 3));
        Assert.assertFalse(solution.isEverywhere(new int[]{3, 1}, 2));
        Assert.assertTrue(solution.isEverywhere(new int[]{3}, 1));
        Assert.assertTrue(solution.isEverywhere(new int[]{}, 1));
        Assert.assertTrue(solution.isEverywhere(new int[]{1, 2, 1, 2, 3, 2, 5}, 2));
        Assert.assertFalse(solution.isEverywhere(new int[]{1, 2, 1, 1, 1, 2}, 2));
        Assert.assertFalse(solution.isEverywhere(new int[]{2, 1, 2, 1, 1, 2}, 2));
        Assert.assertFalse(solution.isEverywhere(new int[]{2, 1, 2, 2, 2, 1, 1, 2}, 2));
        Assert.assertTrue(solution.isEverywhere(new int[]{2, 1, 2, 2, 2, 1, 2, 1}, 2));
        Assert.assertTrue(solution.isEverywhere(new int[]{2, 1, 2, 1, 2}, 2));
    }
}
