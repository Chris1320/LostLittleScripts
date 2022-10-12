#include <stdio.h>


int main(int argc, char *argv[])
{
    int user_input;
    int flag = 4257;

    printf("What is the magic number?: ");
    user_input = scanf("%i", &user_input);

    if (user_input == 0x24791)
    {
        printf("Great! Here is the flag:\n");
        flag += (26 % 2) * 3;
        printf("%i", flag);
    }
    else
    {
        printf("You entered the wrong number.\n");
    }

    return 0;
}
