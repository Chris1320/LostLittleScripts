/**
 * The parameter weekday is true if it is a weekday, and the parameter vacation
 * is true if we are on vacation. We sleep in if it is not a weekday or we're on
 * vacation. Return true if we sleep in.
 * 
 * sleepIn(false, false) → true
 * sleepIn(true, false) → false
 * sleepIn(false, true) → true
 */

class TestCase {
    boolean weekday, vacation, expected;

    public TestCase(boolean weekday, boolean vacation, boolean expected) {
        this.weekday = weekday;
        this.vacation = vacation;
        this.expected = expected;
    }
}

class sleepIn {
    public static boolean sleepIn(boolean weekday, boolean vacation) {
        return !weekday || vacation;
    }

    public static void main(String[] args) {
        TestCase[] testcases = {
                new TestCase(false, false, true),
                new TestCase(true, false, false),
                new TestCase(false, true, true),
                new TestCase(true, true, true),
        };
        for (int i = 0; i < testcases.length; i++) {
            TestCase tc = testcases[i];
            boolean result = sleepIn(tc.weekday, tc.vacation);
            System.out.printf("%b, %b => %b (%b)%n", tc.weekday, tc.vacation, result, tc.expected);
        }
    }
}
