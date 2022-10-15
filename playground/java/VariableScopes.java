public class VariableScopes {
    static int scoped_variable = 71;

    public static void main(String[] args)
    {
        int scoped_variable = 24;

        System.out.println(scoped_variable);  // Output: 24
        anotherFunction();
    }

    static void anotherFunction()
    {
        System.out.println(scoped_variable);  // Output: 71
    }
}
