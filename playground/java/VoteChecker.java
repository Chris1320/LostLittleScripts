import java.util.Scanner;

public class VoteChecker
{
    public static void main(String[] args)
    {
        // ? Define and initialize variables.
        var user_input = new Scanner(System.in);
        int jones_voters, smith_voters, non_voters, total_people;
        float jones_voters_percentage, smith_voters_percentage, non_voters_percentage;

        // ? Ask for user input.
        System.out.print("How many voted for Jones? >>> ");
        jones_voters = user_input.nextInt();
        System.out.print("How many voted for Smith? >>> ");
        smith_voters = user_input.nextInt();
        System.out.print("How many are non-voters? >>> ");
        non_voters = user_input.nextInt();

        // ? Calculate the total voters and percentage of each votes.
        total_people = jones_voters + smith_voters + non_voters;
        jones_voters_percentage = ((float)jones_voters / (float)total_people) * 100.0F;
        smith_voters_percentage = ((float)smith_voters / (float)total_people) * 100.0F;
        non_voters_percentage = ((float)non_voters / (float)total_people) * 100.0F;

        // ? Print the statistics.
        System.out.printf("\nJones:          %s (%.2f%s)\n", jones_voters, jones_voters_percentage, '%');
        System.out.printf("Smith:          %s (%.2f%s)\n", smith_voters, smith_voters_percentage, '%');
        System.out.printf("Non-Voters:     %s (%.2f%s)\n", non_voters, non_voters_percentage, '%');
        System.out.printf("Total Voters:   %s (%.2f%s)\n", jones_voters + smith_voters, jones_voters_percentage + smith_voters_percentage, '%');
        System.out.printf("\nTotal Audience: %s\n\n", total_people);

        // ? Declare the winner of the election.
        if (jones_voters == smith_voters) System.out.println("Nobody won.");
        else if (jones_voters > smith_voters) System.out.println("Jones won.");
        else System.out.println("Smith won.");
    }
}
