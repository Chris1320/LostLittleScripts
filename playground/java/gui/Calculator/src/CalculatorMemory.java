public class CalculatorMemory
{
    byte operation = 0;  // 0 = none; 1 = add; 2 = sub; 3 = mul; 4 = div
    Double prev_input = Double.NaN;  // This will hold the previous number when entering the second number.
    String input = new String();

    public void clear()
    {
        this.operation = 0;
        prev_input = Double.NaN;
    }
}
