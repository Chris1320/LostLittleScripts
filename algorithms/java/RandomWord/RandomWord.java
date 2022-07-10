// Run by setting the `CLASSPATH` variable and running the program.
//
// `CLASSPATH=$PWD/algs4.jar java RandomWord.java < words.txt`
//
// `words.txt` contains a list of words separated by spaces.
// You can also run the program by:
//
// `echo "word1 word2 word3 word4 word5" | CLASSPATH=$PWD/algs4.jar java RandomWord.java`

import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;

public class RandomWord
{
    public static void main(String[] args)
    {
        String champion = "";  // This is the word we are going to print.
        int n = 1;  // The index of the word.
        while (!StdIn.isEmpty())  // Loop while stdin is not empty.
        {
            String word = StdIn.readString();  // Read a string from stdin.
            if (StdRandom.bernoulli(1.0 / n))  // Evaluate whether to print the word.
            {
                champion = word;
            }
            n++;  // Increment `n`
        }
        System.out.println(champion);
    }
}

