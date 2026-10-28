class Expected {
    String input;
    boolean expected;

    public Expected(String input, boolean expected) {
        this.input = input;
        this.expected = expected;
    }
}

class stringE {
    public static boolean stringE(String str) {
        int eq = 0;
        for (int i = 0; i < str.length(); i++) {
            if (str.substring(i, i + 1).equals("e"))
                eq++;
        }

        return eq > 0 && eq < 4;
    }

    public static void main(String[] args) {
        Expected[] testCases = {
                new Expected("hello", true),
                new Expected("heeeello", false),
                new Expected("hi", false),
                new Expected("e", true),
                new Expected("ee", true),
                new Expected("eee", true),
                new Expected("eeee", false)
        };
        for (var input : testCases) {
            var result = stringE(input.input);
            System.out.printf(
                    "Input: %s | Output: %b (Expected: %b)%n",
                    input.input, result, input.expected);
        }
    }
}
