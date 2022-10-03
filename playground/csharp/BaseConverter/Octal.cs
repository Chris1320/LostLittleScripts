class Octal
{
    /// <summary>
    /// This class converts an octal number to other number systems.
    /// </summary>

    private string _val = "0";
    public string val
    {
        get {return _val;}
        private set {}
    }

    public Octal(string user_input_value)
    {
        /// <summary>
        /// The constructor of the Octal() class.
        /// </summary>

        for (int i = 0; i < user_input_value.Length; i++)
        {
            int v = (int)Char.GetNumericValue(user_input_value[i]);
            if (v < 0 || v > 7) throw new ArgumentException("You entered an invalid octal number.");
        }

        for (int i = 0; i < user_input_value.Length; i++)
        {
            if (user_input_value[i] == '0') continue;  // Determine the beginning of the octal number without leading 0s.
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
        int current_exponent = 0;
        for (int i = _val.Length - 1; i >= 0; i--)
        {
            // v * 8^b
            result += Convert.ToInt32(Char.GetNumericValue(_val[i]) * Math.Pow(8, current_exponent++));  // Also increments `current_exponent`.
        }
        return result;
    }
    public string toBinary()
    {
        /// <summary>
        /// Convert to binary.
        /// </summary>

        string result = "";
        for (int i = 0; i < _val.Length; i++)
        {
            string chunk_value = "";
            int remaining = (int)Char.GetNumericValue(_val[i]);

            // Calculate the third bit.
            if (remaining >= 4)
            {
                remaining -= 4;
                chunk_value += "1";
            }
            else chunk_value += "0";

            // Calculate the second bit of the chunk.
            if (remaining >= 2)
            {
                remaining -= 2;
                chunk_value += "1";
            }
            else chunk_value += "0";

            // Calculate the chunk's first bit.
            if (remaining >= 1)
            {
                remaining -= 1;
                chunk_value += "1";
            }
            else chunk_value += "0";

            result += chunk_value;
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j] == '0') continue;  // Determine the beginning of the binary number without leading 0s.
                else
                {
                    result = result.Substring(j, result.Length - j);
                    break;
                }
            }
        }

        return result;
    }

    public string toHexadecimal()
    {
        /// <summary>
        /// Convert to hexadecimal.
        /// </summary>

        // There is no direct way to convert from Octal to Hexadecimal so we
        // will convert it to decimal first, then hexadecimal.
        return new Decimal(toDecimal()).toHexadecimal();
    }
}
