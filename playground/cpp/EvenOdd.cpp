#include <iostream>

int main() {
    // Ask the user for `end` and count the even and
    // odd numbers from `end` to `START` using a while loop.

    // START: The starting number.
    // end:   The user input.
    // i:     The iterator.
    // even:  The number of even numbers.
    // odd:   The number of odd numbers.
    const int START = 0;  // Change this to 1 if you want to start counting with 1.
    int end, i = START, even = 0, odd = 0;
    std::cout << "Enter a number: ";
    std::cin >> end;

    // Use a while loop to count the even and odd numbers.
    // This takes too much processing power.
    while (i <= end) {
        // If the number is even, increment even. Otherwise, increment odd.
        if (i % 2 == 0) even++;
        else odd++;
        i++;  // increment i.
    }

    // Print the result.
    std::cout << "There are " << even << " even numbers and "
        << odd << " odd numbers between " << START << " and " << end <<
        '.' << std::endl;
}
