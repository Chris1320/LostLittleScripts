/**
 * Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or whatever is
 * there if the string is less than length 3. Return n copies of the front;
 * 
 * frontTimes("Chocolate", 2) → "ChoCho"
 * frontTimes("Chocolate", 3) → "ChoChoCho"
 * frontTimes("Abc", 3) → "AbcAbcAbc"
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class FrontTimesSolution {
    public String frontTimes(String str, int n) {
        String front = str.substring(0, Math.min(str.length(), 3));
        String result = "";
        for (int i = 0; i < n; i++) result += front;
        return result;
    }
}
