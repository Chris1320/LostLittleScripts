import java.util.ArrayList;
import java.util.List;

class TestCase {
    public final int n;
    public final String expected;

    public TestCase(int n, String expected) {
        this.n = n;
        this.expected = expected;
    }
}

public class Solution {
    public static String intToRoman(int num) {
        // I = 1
        // V = 5
        // X = 10
        // L = 50
        // C = 100
        // D = 500
        // M = 1000
        var digits = new int[] { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        var numerals = new String[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

        var result = new StringBuilder();
        for (int idx = digits.length - 1; idx >= 0; idx--) {
            while (num >= digits[idx]) {
                result.append(numerals[idx]);
                num -= digits[idx];
            }
        }
        return result.toString();
    }

    public static void main(String[] args) {
        int success = 0;
        List<TestCase> test_cases = new ArrayList<TestCase>() {
            {
                add(new TestCase(3749, "MMMDCCXLIX"));
                add(new TestCase(58, "LVIII"));
                add(new TestCase(1994, "MCMXCIV"));
            }
        };

        for (int i = 0; i < test_cases.size(); i++) {
            var result = Solution.intToRoman(test_cases.get(i).n);
            System.out.printf(
                    "%s == %s\n",
                    result,
                    test_cases.get(i).expected);
            if (result.equals(test_cases.get(i).expected))
                success++;
        }
        System.out.printf("Passed %d/%d test cases.\n", success, test_cases.size());
    }
}

