package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class SameFirstLastSolutionTest {
    @Test
    public void testSameFirstLastSolution() {
        SameFirstLastSolution solution = new SameFirstLastSolution();

        Assert.assertFalse(solution.sameFirstLast(new int[]{1, 2, 3}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{1, 2, 3, 1}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{1, 2, 1}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{7}));
        Assert.assertFalse(solution.sameFirstLast(new int[]{}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{1, 2, 3, 4, 5, 1}));
        Assert.assertFalse(solution.sameFirstLast(new int[]{1, 2, 3, 4, 5, 13}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{13, 2, 3, 4, 5, 13}));
        Assert.assertTrue(solution.sameFirstLast(new int[]{7, 7}));
    }
}
