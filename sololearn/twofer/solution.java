public class Solution
{
    public static void main(String[] args)
    {
        try
        {
            System.out.printf("One for %s, one for me.\n", args[0]);
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            System.out.println("One for you, one for me.");
        }
    }
}
