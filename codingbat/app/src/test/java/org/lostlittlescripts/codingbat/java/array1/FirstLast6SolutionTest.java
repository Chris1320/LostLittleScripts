package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class FirstLast6SolutionTest {
    @Test
    public void testFirstLast6Solution() {
        FirstLast6Solution solution = new FirstLast6Solution();

        Assert.assertTrue(solution.firstLast6(new int[]{1, 2, 6}));
        Assert.assertTrue(solution.firstLast6(new int[]{6, 1, 2, 3}));
        Assert.assertFalse(solution.firstLast6(new int[]{13, 6, 1, 2, 3}));
        Assert.assertFalse(solution.firstLast6(new int[]{3, 2, 1}));
        Assert.assertFalse(solution.firstLast6(new int[]{3, 6, 1}));
        Assert.assertTrue(solution.firstLast6(new int[]{3, 6}));
        Assert.assertTrue(solution.firstLast6(new int[]{6}));
        Assert.assertFalse(solution.firstLast6(new int[]{3}));
        Assert.assertTrue(solution.firstLast6(new int[]{5, 6}));
        Assert.assertFalse(solution.firstLast6(new int[]{5, 5}));
        Assert.assertTrue(solution.firstLast6(new int[]{1, 2, 3, 4, 6}));
        Assert.assertFalse(solution.firstLast6(new int[]{1, 2, 3, 4}));
    }
}
