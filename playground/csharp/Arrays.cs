using System;

namespace ArrayExample
{
    class Program
    {
        static void printDiv(int length)  // Print a divider
        {
            if (!(length < 1))
            {
                Console.Write('*');
                printDiv(--length);
            }
            else Console.Write('\n');
            return;
        }

        static int Main(string[] args)
        {
            int _, head = 0;  // Temporary variables
            bool value_found;
            int selection, user_value;

            const int ARRAY_SIZE = 10;
            int[] array = new int[ARRAY_SIZE];

            while (true)  // Enter loop
            {
                printDiv(40);
                Console.WriteLine("There are " + head + " elements in the array.");
                for (_ = 0; _ < head; _++) Console.WriteLine("Index #" + _ + ": " + array[_]);  // Print elements in array
                Console.Write("\nOperations\n\n[01] Add\n[02] Remove\n\n[99] Quit\n\n >>> ");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        if (head == ARRAY_SIZE)
                        {
                            Console.WriteLine("The array is now full. Please remove elements first.");
                            break;
                        }
                        Console.Write("Enter new value: ");
                        user_value = Convert.ToInt32(Console.ReadLine());
                        array[head] = user_value;
                        Console.WriteLine("Value " + user_value + " was added to array at index " + head + '.');
                        head++;
                        break;

                    case 2:
                        Console.Write("Enter value to remove: ");
                        user_value = Convert.ToInt32(Console.ReadLine());
                        value_found = false;
                        for (_ = 0; _ < head; _++)  // Iterate through the array.
                        {
                            if (array[_] == user_value) value_found = true;  // Set value_found to true when array[_] is what we'll remove.
                            if (value_found && _ < (ARRAY_SIZE - 1)) array[_] = array[_ + 1];
                        }
                        if (value_found)
                        {
                            head--;
                            Console.WriteLine("Value is found and removed from array.");
                        }
                        else Console.WriteLine("Value was not found in the array.");
                        break;

                    case 99:
                        return 0;

                    default:
                        Console.WriteLine("Enter a valid operation.");
                        break;
                }
            }
        }
    }
}
