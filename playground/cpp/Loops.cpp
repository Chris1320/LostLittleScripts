#include <iostream>

using std::cin;
using std::cout;
using std::endl;

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
        if(nums[i] > max) max = nums[i];  // If the current number is greater than the max, set the max to the current number.
        if(nums[i] < min) min = nums[i];  // If the current number is less than the min, set the min to the current number.
    }

    // Print the max and min.
    cout << "The largest number is " << max << endl;
    cout << "The smallest number is " << min << endl;

    return 0;
}
