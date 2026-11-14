package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class Sum3SolutionTest {
    @Test
    public void testSum3Solution() {
        Sum3Solution solution = new Sum3Solution();

        Assert.assertEquals(6, solution.sum3(new int[]{1, 2, 3}));
        Assert.assertEquals(18, solution.sum3(new int[]{5, 11, 2}));
        Assert.assertEquals(7, solution.sum3(new int[]{7, 0, 0}));
        Assert.assertEquals(4, solution.sum3(new int[]{1, 2, 1}));
        Assert.assertEquals(3, solution.sum3(new int[]{1, 1, 1}));
        Assert.assertEquals(11, solution.sum3(new int[]{2, 7, 2}));
    }
}
