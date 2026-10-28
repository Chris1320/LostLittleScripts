/**
 * Given a string, return true if the string starts with "hi" and false
 * otherwise.
 * 
 * startHi("hi there") → true
 * startHi("hi") → true
 * startHi("hello hi") → false
 */

class TestCase {
    String input;
    boolean expected;

    public TestCase(String input, boolean expected) {
        this.input = input;
        this.expected = expected;
    }
}

class startHi {
    public static boolean startHi(String str) {
        return str.startsWith("hi");
    }

    public static void main(String[] args) {
        TestCase[] testCases = {
                new TestCase("hi there", true),
                new TestCase("hi", true),
                new TestCase("hello hi", false),
                new TestCase("he", false),
                new TestCase("h", false),
                new TestCase("", false),
                new TestCase("ho hi", false),
                new TestCase("hi ho", true)
        };

        for (var input : testCases) {
            var result = startHi(input.input);
            System.out.printf(
                    "Input: %s | Output: %b (Expected: %b)%n",
                    input.input, result, input.expected);
        }
    }
}
