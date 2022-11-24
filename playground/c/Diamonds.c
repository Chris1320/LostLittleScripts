#include <stdio.h>

#define BACKGROUND_CHAR "."
#define DISPLAY_CHAR "*"
#define WIDTH 20 // TODO: What if WIDTH is odd? (Diamond isn't perfect)
#define MARGIN 10

void printSpace(int amount)
{
    for (int i = 0; i < amount; i++) printf(BACKGROUND_CHAR);
}

void printChar(int amount)
{
    for (int i = 0; i < amount; i++) printf(DISPLAY_CHAR);
}

int main()
{
    int center;
    for (int i = 1; i < WIDTH; i += 2)
    {
        if ((WIDTH - i) % 2 == 0) center = (WIDTH - i) / 2;
        else center = (WIDTH - i) / 2 + 1;

        printSpace(center + MARGIN);
        printChar(i);
        printSpace(center + MARGIN);
        printf("\n");
    }
    for (int i = WIDTH - 3; i > 0; i -= 2)
    {
        if ((WIDTH - i) % 2 == 0) center = (WIDTH - i) / 2;
        else center = (WIDTH - i) / 2 + 1;

        printSpace(center + MARGIN);
        printChar(i);
        printSpace(center + MARGIN);
        printf("\n");
    }
}
