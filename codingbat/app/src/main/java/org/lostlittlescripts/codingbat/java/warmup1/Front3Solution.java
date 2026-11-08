/**
 * Given a string, we'll say that the front is the first 3 chars of the string. If the string length is less than 3, the front is whatever is there. Return a new string which is 3 copies of the front.
 *
 * front3("Java") → "JavJavJav"
 * front3("Chocolate") → "ChoChoCho"
 * front3("abc") → "abcabcabc"
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class Front3Solution {
    public String front3(String str) {
        String three = str.substring(0, Math.min(3, str.length()));
        return String.format("%1$s%1$s%1$s", three);
    }
}
