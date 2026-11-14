package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class RotateLeft3SolutionTest {
    @Test
    public void testRotateLeft3Solution() {
        RotateLeft3Solution solution = new RotateLeft3Solution();

        Assert.assertArrayEquals(new int[]{2, 3, 1}, solution.rotateLeft3(new int[]{1, 2, 3}));
        Assert.assertArrayEquals(new int[]{11, 9, 5}, solution.rotateLeft3(new int[]{5, 11, 9}));
        Assert.assertArrayEquals(new int[]{0, 0, 7}, solution.rotateLeft3(new int[]{7, 0, 0}));
        Assert.assertArrayEquals(new int[]{2, 1, 1}, solution.rotateLeft3(new int[]{1, 2, 1}));
        Assert.assertArrayEquals(new int[]{0, 1, 0}, solution.rotateLeft3(new int[]{0, 0, 1}));
    }
}
