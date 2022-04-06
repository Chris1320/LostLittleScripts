/*
 * Write a program that reads a sequence of words from standard
 * input and prints one of those words uniformly at random. Do
 * not store the words in an array or list. Instead, use Knuth’s
 * method: when reading the ith word, select it with probability
 * 1/i to be the champion, replacing the previous champion. After
 * reading all of the words, print the surviving champion.
 */

#include <stdio.h>

int main(int argc, char argv[])
{
    int i;
    char candidate[40], champion[40];

    for (i = 0; i < argc; i++)
    {
        // WIP
    }
}
