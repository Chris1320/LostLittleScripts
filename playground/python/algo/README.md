# Algorithm and Complexity: Final Requirement

## Word Unscrambler (Bruteforce)

This program implements a bruteforce algorithm to unscramble anagrams. An anagram
is a word or sentence formed by rearranging the letters of another word. The
program takes a scrambled word and optionally a file containing a
newline-delimited list of valid words as input. It generates all possible
permutations of the input anagram and if provided, compares them against the
dictionary to find matching words.

The core logic of the program is implemented in the `word_unscrambler` function.
It utilizes the `itertools.permutations()` function to generate all possible
arrangements of the letters in the input anagram. Each permutation is then
converted back into a string and checked against a list of valid words (stored
as a set for efficient lookups). If a match is found, it is then added to the
list of unscrambled words.

The `main` function handles command-line arguments using `argparse`. This allows
users to specify the scrambled word, a dictionary file, and toggle verbose
output. The dictionary is loaded from the specified file into a set. The program
handles sentences by splitting them into individual words and unscrambling each
word. User interaction is included to allow the user to select the correct
unscrambled word from multiple options.

The bruteforce strategy used in this program is useful when simplicity is
prioritized because it is straightforward to understand and implement. It is
efficient if the anagrams are short or small dictionaries are used. Finally,
bruteforce strategy is used as a last resort when no other efficient algorithm
is readily available.

Bruteforce is inefficient for larger inputs due to its time complexity of
O(n!), where `n` is the length of the anagram. The execution time grows rapidly
with longer anagrams, making it impractical for large-scale applications.

The program solves the problem of finding valid English words that can be formed
by rearranging the letters of a given scrambled word.

The program can be used in scenarios such as:

- **Word Games**: Solving games like Scrabble or crossword puzzles
- **Code Breaking**: Decrypting simple ciphers like the Caesar or Vigenere
  ciphers where letters are rearranged
- **Educational Tools**: Applications that help people learn vocabulary and
  word patterns
- **Text Analysis**: Identifying word variations or misspellings in text
- **Password Cracking**: Trying all possible combinations

## Company Employee List (Binary Search)

This program implements a binary search algorithm to efficiently manage an
employee list stored in multiple text files. The employee list consists of
two files, one containing employee IDs (integers) and the other employee names
(strings). The program allows users to add new employees and search for
employees by their ID. Binary search is used to quickly locate employees in the
sorted list of IDs.

The program utilizes several functions to manage the employee list. The
`load_employee_list()` function reads employee IDs and names from `ids.txt` and
`names.txt` files, respectively. However, the user can simply change the
filenames by modifying the global variables in the program. The
`save_employee_list()` function is responsible for writing the employee IDs
and names back to the files. `search_employee_list()` implements the binary
search algorithm. It takes a sorted list of employee IDs and a target ID as
input. It repeatedly divides the search space in half until the target ID is
found or the search space is empty. Finally, the `main()` function provides a
menu-driven interface for user interaction. It allows users to add employees,
search for employees, and exit the program.

When adding a new employee, the program first checks if the ID already exists
using the same algorithm for searching, which is the binary search. If the ID
is unique, it is added to the list, and the list is then sorted to maintain
the sorted order required for binary search.

The binary search algorithm is most useful and efficient when the data is
sorted. It also works well with data structures like lists or arrays. Binary
search provides logarithmic time complexity (O(log n)), making it very
efficient for large datasets. It is efficient in scenarios where you need to
perform frequent searches on a large and sorted dataset.

The program can be used in:

- **Contact List Search**: Searching for contacts in a sorted list
- **Database Indexing**: Locate records based on indexed values
- **Dictionary Search**: Finding words in a dictionary or encyclopedia
- **Library Catalog Search**: Locating books in a library catalog using ISBN
- **Finding Data in Sorted Log Files**: Locating specific entries in large and
  sorted log files
- **Finding a specific file on a sorted file system**: On some embedded systems,
  the files are stored in a sorted manner

## Student Score Sorter (Merge Sort)

This program implements the merge sort algorithm to sort student records based
on their grades. It reads student names and grades from a CSV file, sorts them
in ascending order of grades, and displays the sorted and unsorted records in
a tabular format using the `prettytable` library. The program also uses
`colorama` to visually highlight grades based on their range. (green for passing
students, yellow for students close to failing, and red for failing students)

**The program consists of the following functions**:

- `ms_students(sr)`: This function implements the merge sort
  algorithm recursively. It divides the list of student records into two parts,
  recursively sorts each half, and then merges the sorted halves using the
  `m_students()` function.
- `m_students(l, r)`: This function merges two sorted lists of student records.
  It compares the grades of students in the two lists and adds the student with
  the lower grade to the merged list.
- `main()`: This function parses command-line arguments (the CSV file name),
  reads student records from the CSV file, sorts them using the `ms_students()`
  function, and displays the sorted and unsorted records in a tabular format
  using the `prettytable` library. It also uses `colorama` to color-code the
  grades in the tables.

**Recommended Use-Cases For Merge Sort**:

- **Sorting Student Records**: Organizing student data based on grades for reports/analysis
- **Ranking Students**: Generating ranked list of students based on performance
- **Sorting Large Datasets**: Sorting database records or financial data
- **External Sorting**: Sorting data that is too large to fit into memory
- **Parallel Sorting**: Can be used for distributed computing environments
