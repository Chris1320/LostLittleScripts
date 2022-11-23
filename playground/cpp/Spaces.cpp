#include <iostream>

int main()
{
    std::string name;
    std::string frame_end, frame_in;

    std::cout << "Please enter your name: ";
    std::cin >> name;

    const std::string greeting = "Hello, " + name + '!';

    std::string spaces(greeting.size(), ' ');
    std::string asterisks(greeting.size(), '*');

    frame_in = "* " + spaces + " *";
    frame_end = asterisks + "****";

    std::cout << frame_end << '\n';
    std::cout << frame_in << '\n';
    std::cout << "* " + greeting + " *" << '\n';
    std::cout << frame_in << '\n';
    std::cout << frame_end << std::endl;
}
