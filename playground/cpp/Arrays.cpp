#include <iostream>

using std::cin;
using std::cout;
using std::endl;

int main()
{
    // Create an array of 11 characters and initialize it.
    char letters[] = {'h', 'e', 'l', 'l', 'o', ' ', 'w', 'o', 'r', 'l', 'd'};

    // Create an empty array of 5 integers and fill it with values.
    int nums[5];
    for (int i = 0; i < 5; i++)
    {
        cout << "Enter a number: ";
        cin >> nums[i];
    }

    cout << "The letters are: ";
    for (int i = 0; i < 11; i++)
    {
        cout << letters[i];
    }
    cout << endl;

    cout << "The numbers you entered are: ";
    for (int i = 0; i < 5; i++)
    {
        cout << nums[i] << " ";
    }
    cout << endl;

    return 0;  // End program
}
