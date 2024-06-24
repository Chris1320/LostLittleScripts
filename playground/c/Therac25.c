/*
 * This code snippet attempts to simulate the
 * problem of the Therac-25 radiation machine.
 */

#include <stdbool.h>
#include <stdio.h>
#include <string.h>
#include <time.h>

int main(int argc, char *argv[]) {
    time_t magnet_move_start_time;
    int magnet_move_time = 8;  // in seconds
    // xray=high power, electron=low power
    bool magnets_moving, xray_mode = false;

    printf("Therac-25 Radiation Machine\n\n");
    printf("Commands:\n");
    printf("  mode  - Toggle high power mode\n");
    printf("  start - Start blastin'\n");
    printf("  exit  - Exit program\n\n");

    while (true) {
        char command[20];
        printf("Enter command: ");
        scanf("%s", command);

        if (strcmp(command, "mode") == 0) {
            if (magnets_moving) {
                time_t current_time = time(NULL);
                // show failure if magnets are still moving (8 seconds)
                if (current_time - magnet_move_start_time < magnet_move_time) {
                    printf("Failure 54\n");
                    continue;
                }
            }
            xray_mode = !xray_mode;
            printf("Setting mode to: %s \n", xray_mode ? "X-Ray Mode" : "Electron Mode");
            magnets_moving = true;
            magnet_move_start_time = time(NULL);
        }
        else if (strcmp(command, "start") == 0) {
            printf("Starting...\n");
            if (xray_mode) printf("Blasting with X-Rays... Great, your patient is now dead.\n");
            else printf("Blasting with Electrons... Great, cancer cells are now dead.\n");
        }
        else if (strcmp(command, "exit") == 0) { break; }
        else { printf("Invalid command\n"); }
    }
    return 0;
}

