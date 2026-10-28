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
