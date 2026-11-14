package org.lostlittlescripts.codingbat.java.array1;

import org.junit.Assert;
import org.junit.Test;

public class MakePiSolutionTest {
    @Test
    public void testMakePiSolution() {
        MakePiSolution solution = new MakePiSolution();
        Assert.assertArrayEquals(new int[]{3, 1, 4}, solution.makePi());
    }
}
