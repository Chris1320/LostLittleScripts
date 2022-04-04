"""
Deja Vu

You aren't paying attention and you accidentally type a bunch of random letters on your keyboard. You want to know if you ever typed the same letter twice, or if they are all unique letters.

Task:
If you are given a string of random letters, your task is to evaluate whether any letter is repeated in the string or if you only hit unique keys while you typing.

Input Format:
A string of random letter characters (no numbers or other buttons were pressed).

Output Format:
A string that says 'Deja Vu' if any letter is repeated in the input string, or a string that says 'Unique' if there are no repeats.

Sample Input:
aaaaaaaghhhhjkll

Sample Output:
Deja Vu
"""

string = str(input("Enter string: "))  # Read user info
chars = set(())  # Create an empty set
unique = True  # Set default value of `unique`

for char in string:
    if char in chars:
        print("Deja Vu")
        unique = False
        break

    chars.add(char)

if unique:
    print("Unique")
