/**
 * Given a string, return a new string made of 3 copies of the last 2 chars of the original string.
 * The string length will be at least 2.
 * <p>
 * extraEnd("Hello") → "lololo"
 * extraEnd("ab") → "ababab"
 * extraEnd("Hi") → "HiHiHi"
 */

package org.lostlittlescripts.codingbat.java.string1;

public class ExtraEndSolution {
    public String extraEnd(String str) {
        return String.format("%1$s%1$s%1$s", str.substring(str.length() - 2));
    }
}
