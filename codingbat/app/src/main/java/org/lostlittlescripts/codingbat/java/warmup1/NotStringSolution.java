/**
 * Given a string, return a new string where "not " has been added to the front. However, if the string already begins
 * with "not", return the string unchanged. Note: use .equals() to compare 2 strings.
 *
 * notString("candy") → "not candy"
 * notString("x") → "not x"
 * notString("not bad") → "not bad"
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class NotStringSolution {
    public String notString(String str) {
        if (str.startsWith("not")) {
            return str;
        }

        return "not " + str;
    }
}
