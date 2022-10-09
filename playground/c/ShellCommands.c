#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]);

int main(int argc, char *argv[])
{
    // More information about the `system()` function:
    // https://linux.die.net/man/3/system

    printf("Printing current directory content...\n");
    system("ls");
    printf("\nAttempting to call neofetch...\n");
    if (system("neofetch") != 0)
    {
        printf("Failed calling neofetch.\n");
    }

    return 0;
}
