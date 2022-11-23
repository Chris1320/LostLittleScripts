#include <stdio.h>

int main()
{
    // These two string literals will be concatenated by the compiler.
    char a[] = "Hello, " "World!";
    printf("%s\n", a);

    return 0;
}
