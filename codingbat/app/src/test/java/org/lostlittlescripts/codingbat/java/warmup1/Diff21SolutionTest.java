package org.lostlittlescripts.codingbat.java.warmup1;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class Diff21SolutionTest {
    @Test
    public void testDiff21Solution() {
        diff21Solution classUnderTest = new diff21Solution();
        int[][] testcases = {
                { 19, 2 },
                { 10, 11 },
                { 21, 0 },
                { 22, 2 },
                { 25, 8 },
                { 30, 18 },
                { 0, 21 },
                { 1, 20 },
                { 2, 19 },
                { -1, 22 },
                { -2, 23 },
                { 50, 58 },
        };

        for (int[] testcase : testcases) {
            var res = classUnderTest.diff21(testcase[0]);
            System.out.printf("%d => %d (%s)%n", testcase[0], res, res == testcase[1] ? "PASSED" : "FAILED");
            assertEquals(testcase[1], res);
        }
    }
}
