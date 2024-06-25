#include <float.h>
#include <limits.h>
#include <stdio.h>

int main() {
  double actual_velocity = 1.0e10;  // A large number that exceeds INT_MAX
  int converted_velocity;

  // Attempt to convert large_number to a 32-bit signed integer
  converted_velocity = (int)actual_velocity;

  printf("Actual number (64-bit floating point):    %f\n", actual_velocity);
  printf("Converted number (32-bit signed integer): %d\n", converted_velocity);

  // Print the limits of int
  printf("\nAn int can only store values between %d and %d.\n", INT_MIN,
         INT_MAX);

  return 0;
}
