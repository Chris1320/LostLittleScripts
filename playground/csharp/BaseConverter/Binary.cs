class Binary
{
    /// <summary>
    /// This class converts a binary number to other number systems.
    /// </summary>

    private string _val = "0";
    public string val
    {  // Return the private value `_val` and make it read-only.
        get {return _val;}
        private set {}
    }

    public Binary(string user_input_value)
    {
        /// <summary>
        /// The constructor of the Binary() class.
        /// </summary>

        for (int i = 0; i < user_input_value.Length; i++)  // Check if user input is a valid binary number.
        {
            if (user_input_value[i] != '0' && user_input_value[i] != '1')
            {
                throw new ArgumentException("You entered an invalid binary number");
            }
        }

        for (int i = 0; i < user_input_value.Length; i++)
        {
            if (user_input_value[i] == '0') continue;  // Determine the beginning of the binary number without leading 0s.
            else
            {
                _val = user_input_value.Substring(i, user_input_value.Length - i);  // Remove leading 0s from user input.
                break;
            }
        }
    }

    public int toDecimal()
    {
        /// <summary>
        /// Convert to decimal.
        /// </summary>

        int result = 0;
        int current_place_value = 1;
        for (int i = _val.Length - 1; i >= 0; i--)  // Start from the end of `value`.
        {
            if (_val[i] == '1') result += current_place_value;  // If the bit is on, add its place value.
            current_place_value *= 2;  // Multiply the current place value to get `value[i]*10^{n+1}`
        }

        return result;
    }

    public string toOctal()
    {
        /// <summary>
        /// Convert to Octal.
        /// </summary>

        // Check the value first and pad if neccessary.
        string bin_value = _val;  // Copy it to a new variable because we will modify it.
        while (bin_value.Length % 3 != 0) bin_value = "0" + bin_value;  // Check if the value can be divided into three values per chunk.

        // Perform the conversion.
        string result = "";
        for (int i = bin_value.Length - 1; i >= 0; i -= 3)
        {
            int chunk_value = 0;

            if (bin_value[i] == '1') chunk_value += 1;  // Check the last digit of the current chunk.
            if (bin_value[i - 1] == '1') chunk_value += 2;  // Check the second to the last digit of the current chunk.
            if (bin_value[i - 2] == '1') chunk_value += 4;  // Check the third to the last digit of the current chunk.

            result = $"{chunk_value}" + result;
        }

        return result;
    }

    public string toHexadecimal()
    {
        /// <summary>
        /// Convert to Hexadecimal.
        /// </summary>

        // Check the value first and pad if neccessary.
        string bin_value = _val;  // Copy it to a new variable because we will modify it.
        while (bin_value.Length % 4 != 0) bin_value = "0" + bin_value;

        // Perform the conversion.
        string result = "";
        for (int i = bin_value.Length - 1; i >= 0; i -= 4)
        {
            int chunk_value = 0;
            if (bin_value[i] == '1') chunk_value += 1;
            if (bin_value[i - 1] == '1') chunk_value += 2;
            if (bin_value[i - 2] == '1') chunk_value += 4;
            if (bin_value[i - 3] == '1') chunk_value += 8;

            if (chunk_value > 9) result = Hexadecimal.num2Hex(chunk_value) + result;
            else result = $"{chunk_value}" + result;
        }

        return result;
    }
}
