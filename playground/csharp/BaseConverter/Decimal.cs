class Decimal
{
    /// <summary>
    /// This class includes methods for converting a decimal number to other number systems.
    /// </summary>

    private int _val = 0;
    public int val
    {
        get {return _val;}
        private set {}
    }

    public Decimal(int user_input_value)
    {
        /// <summary>
        /// The constructor of the Decimal() class that accepts integers.
        /// </summary>

        _val = user_input_value;
    }

    public Decimal(string user_input_value)
    {
        /// <summary>
        /// The constructor of the Decimal() class that accepts strings.
        /// </summary>

        _val = Convert.ToInt32(user_input_value);
    }

    public string toBinary()
    {
        /// <summary>
        /// Convert the decimal number to binary.
        /// </summary>

        string result = "";
        int remaining = val;
        while (remaining > 0)
        {
            result = Convert.ToString(remaining % 2) + result;  // Get the remainder of `remaining mod 2`.
            remaining = remaining / 2;  // Perform an integer division.
        }

        return result;
    }

    public string toOctal()
    {
        /// <summary>
        /// Convert the decimal number to octal.
        /// </summary>

        string result = "";
        int remaining = val;
        while (remaining > 0)
        {
            result = Convert.ToString(remaining % 8) + result;
            remaining = remaining / 8;  // Perform an integer division.
        }

        return result;
    }

    public string toHexadecimal()
    {
        /// <summary>
        /// Convert the decimal number to hexadecimal.
        /// </summary>

        int remainder;
        string result = "";
        int remaining = val;
        while (remaining > 0)
        {
            remainder = remaining % 16;
            if (remainder > 9) result = Hexadecimal.num2Hex(remainder) + result;
            else result = Convert.ToString(remainder) + result;
            remaining = remaining / 16;  // Perform an integer division.
        }

        return result;
    }
}
