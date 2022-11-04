public class CompareToString
{
    public static void main(String[] args)
    {
        String a = "duke";
        String b = "Duke";
        System.out.println(a.compareTo(b));  // Output: 32

        /*
         * ASCII value of `d`: 100
         * ASCII value of `D`: 68
         *
         * d - b = 100 - 68 = 32
         */
    }
}
