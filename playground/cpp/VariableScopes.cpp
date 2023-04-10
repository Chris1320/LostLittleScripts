#include <iostream>

using std::cout;
using std::endl;
using std::string;

int main() {
    int i = 25;  // i is in the outer scope
    cout << "The value of i is " << i << endl;

    for (int i = 0; i < 10; ++i)  // i is in the inner scope
    {
        cout << "The value of i is " << i << endl;
    }

    // i is still in the outer scope
    cout << "The value of i is " << i << endl;
    return 0;
}
