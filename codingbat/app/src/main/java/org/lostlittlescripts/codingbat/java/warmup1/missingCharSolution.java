/**
 * Given a non-empty string and an int n, return a new string where the char at
 * index n has been removed. The value of n will be a valid index of a char in
 * the original string (i.e. n will be in the range 0..str.length()-1
 * inclusive).
 * 
 * missingChar("kitten", 1) → "ktten"
 * missingChar("kitten", 0) → "itten"
 * missingChar("kitten", 4) → "kittn"
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class missingCharSolution {
    public String missingChar(String str, int n) {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.length(); i++) {
            if (i != n) {
                result.append(str.charAt(i));
            }
        }
        return result.toString();
    }

}
