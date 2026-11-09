/**
 * Given a string, take the first 2 chars and return the string with the 2 chars added at both the front and back, so
 * "kitten" yields"kikittenki". If the string length is less than 2, use whatever chars are there.
 *
 * front22("kitten") → "kikittenki"
 * front22("Ha") → "HaHaHa"
 * front22("abc") → "ababcab"
 */

package org.lostlittlescripts.codingbat.java.warmup1;

class Front22Solution {
    public String front22(String str) {
        String edge = str.substring(0, Math.min(str.length(), 2));
        return String.format("%1$s%2$s%1$s", edge, str);
    }
}
