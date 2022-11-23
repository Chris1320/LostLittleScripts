/*
 * David and Alex each have aquariums. There are 8 Rainbowfishes in David’s aquarium,
 * and 11 Angelfishes in Alex’s aquarium. Help them exchange their fishes between them.
 * Complete the code to swap the values of variables between aquariumDavid and aquariumAlex.
 *
 * Source: sololearn.com
 */

#include <iostream>

using namespace std;

int main()
{
    int aquariumDavid = 8;
    int aquariumAlex = 11;

    swap(aquariumAlex, aquariumDavid);  // swap contents of the variables.

    cout << "David's aquarium: " << aquariumDavid << endl;
    cout << "Alex's aquarium: " << aquariumAlex << endl;
    return 0;
}
