import java.util.Scanner;

class BMICalculator {
    public static void main(String[] args) {
        try (var scanner = new Scanner(System.in)) {
            System.out.println("BMI Calculator");

            // 1. Require input from the user
            System.out.print("Enter your weight (kg) >>> ");
            float weight = scanner.nextFloat();
            System.out.print("Enter your height (m) >>> ");
            float height = scanner.nextFloat();
            if (weight <= 0 || height <= 0) {
                System.out.println("Invalid input. Please enter positive numbers for weight and height.");
                return;
            }

            // 2. Calculate results
            var bmi = weight / (height * height);
            String category;

            if (bmi < 18.5) category = "Underweight";
            else if (bmi < 25) category = "Normal";
            else if (bmi < 30) category = "Overweight";
            else category = "Obese";

            // 3. Print out results
            System.out.printf("BMI: %.2f%nCategory: %s%n", bmi, category);
        }
    }
}
