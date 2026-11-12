/**
 * Given a string, return true if the first instance of "x" in the string is
 * immediately followed by another "x".
 * 
 * doubleX("axxbb") → true
 * doubleX("axaxax") → false
 * doubleX("xxxxx") → true
 */

package org.lostlittlescripts.codingbat.java.warmup2;

class DoubleXSolution {
    boolean doubleX(String str) {
        int firstInstance = str.indexOf('x');
        if (firstInstance == -1 || firstInstance + 2 > str.length()) {
            return false;
        }
        return str.substring(firstInstance, firstInstance + 2).contentEquals("xx");
    }
}
