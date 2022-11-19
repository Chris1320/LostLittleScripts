/*
 * Bingo Card Generator
 */

import java.util.Arrays;
import java.util.Random;
import java.lang.StringBuilder;

public class BingoCardGenerator
{
    public static void main(String[] args)
    {
        // ? Create two new bingo card objects.
        var card1 = new BingoCard();
        var card2 = new BingoCard();

        // ? Print card contents.
        System.out.println("Card #1:");
        System.out.println(card1.printCard());
        System.out.println("Card #2:");
        System.out.println(card2.printCard());

        // ? Re-shuffle cards.
        card1.regenerateCard();
        card2.regenerateCard();

        // ? Print card contents in the same line
        String[] card1_result = card1.printCard().split("\n");  // Create a string array.
        String[] card2_result = card2.printCard().split("\n");
        var result = new StringBuilder();

        for (int i = 0; i < card1_result.length && i < card2_result.length; i++)
        {
            result.append(card1_result[i] + " ".repeat(20) + card2_result[i] + '\n');
        }

        System.out.println(result.toString());
    }
}

public class BingoCard
{
    // NOTE: This class should be on a different file as good practice.

    // These arrays contain possible values of each letter.
    private static final int[][] _possible_values = {
        {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15},  // Possible values for B
        {16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30},  // Possible values for I
        {31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45},  // Possible values for N
        {46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60},  // Possible values for G
        {61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75}  // Possible values for O
    };

    private Random random = new Random();  // Randomizer class
    public int card_width = 5;  // B-I-N-G-O
    public int card_length = 5;  // How long is the card
    // This 2D array will contain the values of the card.
    public int[][] card_contents = new int[card_width][card_length];

    public BingoCard()  // Class constructor
    {
        this.regenerateCard();  // Generate the cards for the first time.
    }

    private boolean alreadyInCard(int column, int possible_candidate)
    {
        // Checks if possible_candidate is in this.card_contents.

        for (int number : this.card_contents[column])
        {
            if (number == possible_candidate) return true;
        }
        return false;
    }

    private String centerText(String text_to_center, int length)
    {
        // Add spacing at the sides of the text.

        String result = "";
        int len1 = (length - text_to_center.length()) / 2;
        int len2 = (length - text_to_center.length()) / 2;
        if ((length - text_to_center.length()) % 2 != 0) len2++;

        for (int i = 0; i < len1; i++) result += ' ';
        result += text_to_center;  // Add the text to center in the middle.
        for (int i = 0; i < len2; i++) result += ' ';
        return result;
    }

    public void regenerateCard()
    {
        // Randomly choose a number from this._possible_values and add it to this.card_contents

        for (int column = 0; column < this.card_width; column++)
        {
            for (int row = 0; row < this.card_length; row++)
            {
                if (column == 2 && row == 2)
                {
                    // Set it as a free square. (This is a Bingo rule, iirc)
                    this.card_contents[column][row] = 0;
                    continue;
                }

                int possible_candidate;
                do
                {
                    possible_candidate = this._possible_values[column][this.random.nextInt(this._possible_values[column].length)];
                }
                // Avoid duplication
                while (this.alreadyInCard(column, possible_candidate));
                this.card_contents[column][row] = possible_candidate;
            }
        }
    }

    public String printCard()
    {
        var result = new StringBuilder();
        result.append("\n|  B  |  I  |  N  |  G  |  O  |\n");
        result.append("|-----|-----|-----|-----|-----|\n");
        for (int row = 0; row < this.card_length; row++)
        {
            result.append('|');
            for (int column = 0; column < this.card_width; column++)
            {
                String square_content;
                if (this.card_contents[column][row] == 0) square_content = this.centerText("FREE!", 5) + "|";
                else square_content = this.centerText(
                    Integer.toString(this.card_contents[column][row]), 5
                ) + "|";

                result.append(square_content);
            }
            result.append('\n');
        }
        return result.toString();
    }
}
