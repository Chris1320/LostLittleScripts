public class Strings {
    public static void main(String[] args)
    {
        String some_string = "Some Name Here";  // Checks if the string is in the pool first.
        String another_string = new String("Another Name Here");  // Creates a new object regardless if it's already in memory or not.

        System.out.println(some_string);
        System.out.println(another_string);
    }
}
