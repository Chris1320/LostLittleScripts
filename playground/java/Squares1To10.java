// Output all the numbers and their squares between 1 to 10.

public class Squares1To10
{
    public static void main(String[] args)
    {
        int i = 1;
        while (i <= 10)
        {
            System.out.printf("%d\t%d\n", i, i * i);
            i++;
        }
    }
}
