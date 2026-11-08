/**
 * Given a string, return a new string where the first and last chars have been exchanged.
 *
 * frontBack("code") → "eodc"
 * frontBack("a") → "a"
 * frontBack("ab") → "ba"
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class frontBackSolution {
    public String frontBack(String str) {
        if (str.length() <= 1) {
            return str;
        }

        char first = str.charAt(0);
        char last = str.charAt(str.length() - 1);
        return String.format("%c%s%c", last, str.subSequence(1, str.length() - 1).toString(), first);
    }
}
