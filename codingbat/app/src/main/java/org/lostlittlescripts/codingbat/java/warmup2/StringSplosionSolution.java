/**
 * Given a non-empty string like "Code" return a string like "CCoCodCode".
 * <p>
 * stringSplosion("Code") → "CCoCodCode"
 * stringSplosion("abc") → "aababc"
 * stringSplosion("ab") → "aab"
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class StringSplosionSolution {
    public String stringSplosion(String str) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            result.append(str, 0, i + 1);
        }

        return result.toString();
    }
}
