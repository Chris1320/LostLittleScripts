/*
 * David and Alex each have aquariums. There are 8 Rainbowfishes in David’s aquarium,
 * and 11 Angelfishes in Alex’s aquarium. Help them exchange their fishes between them.
 * Complete the code to swap the values of variables between aquariumDavid and aquariumAlex.
 *
 * Source: sololearn.com
 */

#include <iostream>

int main()
{
    int aquariumDavid = 8;
    int aquariumAlex = 11;

    std::swap(aquariumAlex, aquariumDavid);  // swap contents of the variables.

    std::cout << "David's aquarium: " << aquariumDavid << '\n';
    std::cout << "Alex's aquarium: " << aquariumAlex << std::endl;
    return 0;
}
