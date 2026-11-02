/**
 * We have a loud talking parrot. The "hour" parameter is the current hour time
 * in the range 0..23. We are in trouble if the parrot is talking and the hour
 * is before 7 or after 20. Return true if we are in trouble.
 * 
 * parrotTrouble(true, 6) → true
 * parrotTrouble(true, 7) → false
 * parrotTrouble(false, 6) → false
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class parrotTroubleTestCase {
    boolean talking;
    int hour;
    boolean expected;

    public parrotTroubleTestCase(boolean talking, int hour, boolean expected) {
        this.talking = talking;
        this.hour = hour;
        this.expected = expected;
    }
}

class parrotTroubleSolution {
    public static boolean parrotTrouble(boolean talking, int hour) {
        return (hour < 7 || hour > 20) && talking;
    }

    public static void main(String[] args) {
        parrotTroubleTestCase[] testCases = {
                new parrotTroubleTestCase(true, 6, true),
                new parrotTroubleTestCase(true, 7, false),
                new parrotTroubleTestCase(false, 6, false),
                new parrotTroubleTestCase(true, 21, true),
                new parrotTroubleTestCase(false, 21, false),
                new parrotTroubleTestCase(false, 20, false),
                new parrotTroubleTestCase(true, 23, true),
                new parrotTroubleTestCase(false, 23, false),
                new parrotTroubleTestCase(true, 20, false),
                new parrotTroubleTestCase(false, 12, false)
        };

        for (parrotTroubleTestCase testCase : testCases) {
            boolean result = parrotTrouble(testCase.talking, testCase.hour);
            System.out.printf("parrotTrouble(%b, %d) = %b | Expected: %b | %s%n",
                    testCase.talking, testCase.hour, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }
}
