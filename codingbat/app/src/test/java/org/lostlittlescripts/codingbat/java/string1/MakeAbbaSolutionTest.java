package org.lostlittlescripts.codingbat.java.string1;

import org.junit.Assert;
import org.junit.Test;

public class MakeAbbaSolutionTest {
    @Test
    public void testMakeAbbaSolution() {
        MakeAbbaSolution solution = new MakeAbbaSolution();

        Assert.assertEquals("HiByeByeHi", solution.makeAbba("Hi", "Bye"));
        Assert.assertEquals("YoAliceAliceYo", solution.makeAbba("Yo", "Alice"));
        Assert.assertEquals("WhatUpUpWhat", solution.makeAbba("What", "Up"));
        Assert.assertEquals("aaabbbbbbaaa", solution.makeAbba("aaa", "bbb"));
        Assert.assertEquals("xyyx", solution.makeAbba("x", "y"));
        Assert.assertEquals("xx", solution.makeAbba("x", ""));
        Assert.assertEquals("yy", solution.makeAbba("", "y"));
        Assert.assertEquals("BoYaYaBo", solution.makeAbba("Bo", "Ya"));
        Assert.assertEquals("YaYaYaYa", solution.makeAbba("Ya", "Ya"));
    }
}
