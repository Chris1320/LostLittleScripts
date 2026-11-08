/**
 * We have two monkeys, a and b, and the parameters aSmile and bSmile indicate
 * if each is smiling. We are in trouble if they are both smiling or if neither
 * of them is smiling. Return true if we are in trouble.
 * 
 * monkeyTrouble(true, true) → true
 * monkeyTrouble(false, false) → true
 * monkeyTrouble(true, false) → false
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class MonkeyTroubleSolution {
    public static boolean monkeyTrouble(boolean aSmile, boolean bSmile) {
        return aSmile == bSmile;
    }

    public static void main(String[] args) {
        boolean[][] testcases = {
                { true, true, true },
                { false, false, true },
                { true, false, false },
                { false, true, false }
        };

        for (boolean[] tc : testcases) {
            System.out.printf("a = %b | b = %b | result = %b | expected = %b%n",
                    tc[0], tc[1], monkeyTrouble(tc[0], tc[1]), tc[2]);
        }
    }
}
