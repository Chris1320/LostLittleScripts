#include <iostream>

int main() {
    // Ask the user for a number and count the even and odd numbers in the number range.

    // START: the starting number.
    // number: the user input.
    // i: the iterator.
    // even: the number of even numbers.
    // odd: the number of odd numbers.
    const int START = 1;  // Change this to 1 if you want to start counting with 1.
    int number, i = START, even = 0, odd = 0;
    std::cout << "Enter a number: ";
    std::cin >> number;

    // Use a while loop to count the even and odd numbers.
    // This takes too much processing power.
    while (i <= number) {
        // If the number is even, increment even. Otherwise, increment odd.
        if (i % 2 == 0) even++;
        else odd++;
        i++;  // increment i.
    }

    // Print the result.
    std::cout << "There are " << even << " even numbers and "
        << odd << " numbers between " << START << " and " << number <<
        '.' << std::endl;
}
