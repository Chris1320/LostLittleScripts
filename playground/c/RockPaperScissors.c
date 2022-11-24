#include <time.h>
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>

#define MIN_PLAYERS 1
#define MAX_PLAYERS 2

#ifdef _WIN32
    const int IS_WIN = 1;

#else
    const int IS_WIN = 0;

#endif

// Function declarations
void setupGame();
void clearScreen();
void startGame(int players);

const char PROGRAM_NAME[] = "Rock Paper Scissors";

void clearScreen()
{
    if (IS_WIN) system("cls");
    else system("clear");
}

void setupGame()
{
    int number_of_players;
    while (1)
    {
        clearScreen();
        printf("\n%s\n[1] One Player\n[2] Two Players\n\n >>> ", PROGRAM_NAME);
        scanf("%d%*c", &number_of_players);
        if (number_of_players <= MAX_PLAYERS && number_of_players >= MIN_PLAYERS)
        {
            startGame(number_of_players);
            return;
        }
        else
        {
            printf("[ERROR] Invalid Input. (You entered: `%d`)\n", number_of_players);
            getchar();
        }
    }
}

void startGame(int players)
{
    int p1_choice, p2_choice;
    char weapon_names[][9] = {"Rock", "Paper", "Scissors"};
    // ? The arrangement of the weapons are used in the evaluation of the winner below.
    char prompt[] = "[1] Rock\n[2] Paper\n[3] Scissors\n\nChoose your weapon >>> ";
    do  // Ask player 1 for input.
    {
        clearScreen();
        printf("Player #1\n\n");
        printf("%s", prompt);
        scanf("%d%*c", &p1_choice);
    }
    while (p1_choice < 1 || p1_choice > 3);

    if (players == 2)
    {
        do  // Ask player 2 for input.
        {
            clearScreen();
            printf("Player #2\n\n");
            printf("%s", prompt);
            scanf("%d%*c", &p2_choice);
        }
        while (p2_choice < 1 || p2_choice > 3);
    }
    else p2_choice = (rand() % 3) + 1;

    printf("\n");  // Add a space between the user input and the results.

    // Evaluate their choices and declare the winner.
    if (p1_choice == p2_choice) printf("It's a tie.\n");
    else if (p1_choice % 3 == p2_choice - 1) printf("Player #2 won.\n");  // `n % 3` always beats `n - 1`.
    else printf("Player #1 won.\n");

    printf("- Player 1 used %s.\n- Player 2 used %s.\n", weapon_names[p1_choice - 1], weapon_names[p2_choice - 1]);
    getchar();
}

// Main function
int main(int argc, char *argv[])
{
    char menu_choice;
    srand(time(NULL));  // Seed the random number generator.
    while (1)
    {
        clearScreen();
        printf("\n%s\n[S] Start Game\n[Q] Quit\n\n >>> ", PROGRAM_NAME);
        scanf("%c%*c", &menu_choice);
        switch (tolower(menu_choice))
        {
            case 's':
                setupGame();
                break;

            case 'q':
                printf("Exiting...\n");
                return 0;

            default:
                printf("[ERROR] Invalid input. (You entered `%c`)\n", menu_choice);
                getchar();
        }
    }
}
