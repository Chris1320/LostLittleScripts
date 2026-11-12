/**
 * Given two strings, a and b, return the result of putting them together in the order abba,
 * e.g. "Hi" and "Bye" returns "HiByeByeHi".
 *
 * makeAbba("Hi", "Bye") → "HiByeByeHi"
 * makeAbba("Yo", "Alice") → "YoAliceAliceYo"
 * makeAbba("What", "Up") → "WhatUpUpWhat"
 */

package org.lostlittlescripts.codingbat.java.string1;

public class MakeAbbaSolution {
    public String makeAbba(String a, String b) {
        return String.format("%1$s%2$s%2$s%1$s", a, b);
    }
}
