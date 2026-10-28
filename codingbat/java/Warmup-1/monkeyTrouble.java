/**
 * We have two monkeys, a and b, and the parameters aSmile and bSmile indicate
 * if each is smiling. We are in trouble if they are both smiling or if neither
 * of them is smiling. Return true if we are in trouble.
 * 
 * monkeyTrouble(true, true) → true
 * monkeyTrouble(false, false) → true
 * monkeyTrouble(true, false) → false
 */

class TestCase {
    boolean a, b, expected;

    public TestCase(boolean a, boolean b, boolean expected) {
        this.a = a;
        this.b = b;
        this.expected = expected;
    }
}

class monkeyTrouble {
    public static boolean monkeyTrouble(boolean aSmile, boolean bSmile) {
        return aSmile == bSmile;
    }

    public static void main(String[] args) {
        TestCase[] testcases = {
                new TestCase(true, true, true),
                new TestCase(false, false, true),
                new TestCase(true, false, false),
                new TestCase(false, true, false)
        };

        for (int i = 0; i < testcases.length; i++) {
            var tc = testcases[i];
            System.out.printf("a = %b | b = %b | result = %b | expected = %b%n",
                    tc.a, tc.b, monkeyTrouble(tc.a, tc.b), tc.expected);
        }
    }
}
