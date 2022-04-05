#include <stdio.h>
#include <stdbool.h>

void printDiv(int length)  /* Print a divider. */
{
    printf("*");
    if (length > 1) return printDiv(--length);
    printf("\n");
    return;
}

int main()
{
    int array_size = 10;  // Set array size. (Also used in value removal, so it is in its own variable)
    int array[array_size];  // Declare the array of ints.

    int _, user_selection, user_value;
    int selector = 0;  // Set default index of selector
    bool value_found;  // Temporary value for storing information if the value to be removed is found.

    while (true)  // Enter loop
    {
        printf("\n");
        printDiv(40);  // Call a function to show a divider.
        printf("\nThere are currently %d elements in the array.\n\n", selector);
        for (_ = 0; _ < selector; _++) printf("+ Index #%d: %d\n", _, array[_]);  // Print all elements in the array for the user to see.

        printf("\nOperation\n[01] Add\n[02]Remove\n\n[99] Quit\n\n\n >>> ");
        scanf("%d", &user_selection);

        switch (user_selection)  // Evaluate user input.
        {
            case 1:
                if (selector == array_size)  // Check if array is already the size of the assigned size.
                {
                    printf("The array is already full. Please remove some elements first.\n");
                    break;
                }
                /* ? If I remove the if condition above,
                 * why does the program let the user
                 * add three more values to the array
                 * (total of 13 elements in the array)
                 * before raising a segmentation fault?
                 */

                printf("Enter value to add: ");
                scanf("%d", &user_value);  // Read user input.
                array[selector] = user_value;  // Set value of the selected index on array.
                selector++;  // Increment selector to mark the old one as occupied.
                printf("Number %d is added on index #%d.", user_value, (selector - 1));
                break;

            case 2:
                printf("Enter value to remove (first value that matches is deleted if there are any duplicates): ");
                scanf("%d", &user_value);  // Read user input.
                value_found = false;  // Set initial value of the variable.
                for (_ = 0; _ < selector; _++)  // Loop through the array.
                {
                    if (array[_] == user_value) value_found = true;  // The value is now found.
                    if (value_found && (_ < array_size)) array[_] = array[_ + 1];  // Overwrite if value is found.
                }
                selector--;  // Decrement selector to mark the last array as free.
                if (value_found) printf("Number %d is found and removed from the array.\n", user_value);
                else printf("%d does not exist on the array.", user_value);
                break;

            case 99:
                return 0;

            default:
                printf("Enter a valid input.\n");
                break;
        }
    }
}
