class Hexadecimal
{
    /// <summary>
    /// This class does the conversion from hexadecimal to other number systems.
    /// </summary>

    private string _val = "";
    public string val
    {
        get {return _val;}
        private set {}
    }
    private static Dictionary<int, char> hex_values = new Dictionary<int, char>(){
        {10, 'A'},
        {11, 'B'},
        {12, 'C'},
        {13, 'D'},
        {14, 'E'},
        {15, 'F'}
    };
    private static Dictionary<char, int> dec_values = new Dictionary<char, int>(){
        {'A', 10},
        {'B', 11},
        {'C', 12},
        {'D', 13},
        {'E', 14},
        {'F', 15}
    };
    private char[] hex_chars = {
        '0', '1', '2', '3', '4', '5', '6',
        '7', '8', '9', 'A', 'B',
        'C', 'D', 'E', 'F'};

    public Hexadecimal(string user_input_value)
    {
        /// <summary>
        /// The constructor of the Hexadecimal() class.
        /// </summary>

        bool nonzero_start_detected = false;  // This variable is used to remove leading 0s of the hex number.
        for (int i = 0; i < user_input_value.Length; i++)
        {
            if (!nonzero_start_detected)
            {
                if (user_input_value[i] == '0') continue;
                else nonzero_start_detected = true;
            }
            char value_char = Char.ToUpper(user_input_value[i]);
            if (!hex_chars.Contains(value_char))
            {
                throw new ArgumentException("You entered an invalid hexadecimal number.");
            }
            else _val += value_char;
        }
    }

    public int toDecimal()
    {
        /// <summary>
        /// Convert to decimal.
        /// </summary>
        int result = 0;
        int current_exponent = _val.Length - 1;

        for (int i = 0; i < _val.Length; i++)
        {
            result += Convert.ToInt32(hex2Num(_val[i]) * Math.Pow(16, current_exponent--));
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
            int current_value = hex2Num(_val[i]);

            if (current_value >= 8)
            {
                current_value -= 8;
                chunk_value += "1";
            }
            else chunk_value += "0";

            if (current_value >= 4)
            {
                current_value -= 4;
                chunk_value += "1";
            }
            else chunk_value += "0";

            if (current_value >= 2)
            {
                current_value -= 2;
                chunk_value += "1";
            }
            else chunk_value += "0";

            if (current_value >= 1)
            {
                current_value -= 1;
                chunk_value += "1";
            }
            else chunk_value += "0";

            result += chunk_value;
        }

        for (int j = 0; j < result.Length; j++)
        {
            if (result[j] == '0') continue;  // Determine the beginning of the binary number without leading 0s.
            else
            {
                result = result.Substring(j, result.Length - j);
                break;
            }
        }
        return result;
    }

    public string toOctal()
    {
        /// <summary>
        /// Convert to octal.
        ///
        /// There is no direct way to convert hex to octal, so we
        /// will convert it to decimal first, and then into octal.
        /// </summary>

        return new Decimal(toDecimal()).toOctal();
    }

    public static char num2Hex(int num)
    {
        /// <summary>
        /// Convert `num` to its hexadecimal form.
        /// </summary>

        if (hex_values.ContainsKey(num))
        {
            return hex_values[num];
        }

        return (char)num;
    }

    public static int hex2Num(char hex_char)
    {
        /// <summary>
        /// Convert hexadecimal to its decimal form.
        /// </summary>

        if (dec_values.ContainsKey(hex_char))
        {
            return dec_values[hex_char];
        }

        return (int)Char.GetNumericValue(hex_char);
    }
}
