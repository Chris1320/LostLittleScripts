public class ClassLevelVariables
{
    static int empty_variable;  // This will default to `0` because
                                // Java automatically sets a default
                                // value to the variable.

    public static void main(String[] args)
    {
        System.out.println("The value of empty_variable is " + empty_variable + '.');
    }
}
