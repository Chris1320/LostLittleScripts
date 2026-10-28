/**
 * We have a loud talking parrot. The "hour" parameter is the current hour time
 * in the range 0..23. We are in trouble if the parrot is talking and the hour
 * is before 7 or after 20. Return true if we are in trouble.
 * 
 * parrotTrouble(true, 6) → true
 * parrotTrouble(true, 7) → false
 * parrotTrouble(false, 6) → false
 */

class TestCase {
    boolean talking;
    int hour;
    boolean expected;

    public TestCase(boolean talking, int hour, boolean expected) {
        this.talking = talking;
        this.hour = hour;
        this.expected = expected;
    }
}

class parrotTrouble {
    public static boolean parrotTrouble(boolean talking, int hour) {
        return (hour < 7 || hour > 20) && talking;
    }

    public static void main(String[] args) {
        TestCase[] testCases = {
                new TestCase(true, 6, true),
                new TestCase(true, 7, false),
                new TestCase(false, 6, false),
                new TestCase(true, 21, true),
                new TestCase(false, 21, false),
                new TestCase(false, 20, false),
                new TestCase(true, 23, true),
                new TestCase(false, 23, false),
                new TestCase(true, 20, false),
                new TestCase(false, 12, false)
        };

        for (TestCase testCase : testCases) {
            boolean result = parrotTrouble(testCase.talking, testCase.hour);
            System.out.printf("parrotTrouble(%b, %d) = %b | Expected: %b | %s%n",
                    testCase.talking, testCase.hour, result, testCase.expected,
                    result == testCase.expected ? "PASS" : "FAIL");
        }
    }
}
