#include <stdio.h>
#include <string.h>

#define TEST_CASES_LEN 3

struct testCase {
  char* roman;
  int expected;
};

/**
 * @brief Convert roman numerals to integer.
 *
 * @param s The roman numerals in string form.
 * @return The integer form of <s>.
 */
int romanToInt(char* s) {
  int result = 0;
  int prev = 4321;  // Set to high by default
  for (int i = 0; i < strlen(s); i++) {
    int present;
    switch (s[i]) {
      case 'I':
        present = 1;
        break;
      case 'V':
        present = 5;
        break;
      case 'X':
        present = 10;
        break;
      case 'L':
        present = 50;
        break;
      case 'C':
        present = 100;
        break;
      case 'D':
        present = 500;
        break;
      case 'M':
        present = 1000;
        break;
      default:
        present = -1;
        break;
    }

    if (present == -1) continue;  // invalid roman numeral
    if (prev < present) {
      // Subtract <prev> from <present>
      // and remove previously added <prev>
      result += present - (prev * 2);
    } else {
      result += present;
    }

    prev = present;
  }
  return result;
}

int main() {
  struct testCase test_cases[TEST_CASES_LEN];
  test_cases[0].roman = "III";
  test_cases[0].expected = 3;
  test_cases[1].roman = "LVIII";
  test_cases[1].expected = 58;
  test_cases[2].roman = "MCMXCIV";
  test_cases[2].expected = 1994;

  for (int i = 0; i < TEST_CASES_LEN; i++) {
    printf("%s == %d (expected: %d)\n", test_cases[i].roman,
           romanToInt(test_cases[i].roman), test_cases[i].expected);
  }

  return 0;
}
