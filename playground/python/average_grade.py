name = input("Student name: ")
subjects = int(input("How many subjects? > "))
i = 0
grades = []  # Initialize empty list
while i < subjects:
    grades.append(float(input(f"Enter grade #{i + 1}: ")))  # Append grade to list
    i += 1  # Increment i

print(f"\nAverage grade: {sum(grades) / len(grades)}")  # Print average grade
