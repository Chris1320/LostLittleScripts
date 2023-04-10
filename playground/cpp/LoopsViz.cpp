#include <iostream>
#include <string>

using std::cin;
using std::cout;
using std::endl;
using std::string;

int main()
{
    // Ask the user for 7 numbers and store them in an array.
    int nums[7];
    cout << "Enter 7 numbers: " << endl;
    for (int i = 0; i < 7; i++) cin >> nums[i];

    // Set the max and min to the first number in the array.
    int max = nums[0];
    int min = nums[0];

    // Loop through the array and find the max and min.
    for(int i = 1; i < 7; i++)
    {
        cout << "Current value of i: " << std::to_string(i) << '\n' <<
            "Current value of max: " << std::to_string(max) << '\n' <<
            "Current value of min: " << std::to_string(min) << '\n' <<
            "Current value of nums[" << std::to_string(i) << "]: " << std::to_string(nums[i]) << '\n';
        if(nums[i] > max) {
            cout << "nums is greater than max. Setting it as the new max.\n";
            max = nums[i];  // If the current number is greater than the max, set the max to the current number.
        }
        else if(nums[i] < min) {
            cout << "nums is less than min. Setting it as the new min.\n";
            min = nums[i];  // If the current number is less than the min, set the min to the current number.
        }
        else cout << "nums is neither greater than max nor less than min. Skipping.\n";
        cout << "\nPress enter to continue...\n\n";
        cin.get();
    }

    // Print the max and min.
    cout << "The largest number is " << max << endl;
    cout << "The smallest number is " << min << endl;

    return 0;
}
