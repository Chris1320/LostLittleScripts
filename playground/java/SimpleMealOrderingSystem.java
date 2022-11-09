/*
 * Using if statements and JOptionPane, write a program in Java that will assign a value
 * in a meal, drink, and quantity, and identify the equivalent according to the following.
 *
 * Meal  Package              Price
 * A     Chicken & Spaghetti  150
 * B     Hamburger & Fries    145
 * C     Cheesedog            100
 * D     Pizza                80
 *
 * Drink  Size                Price
 * A     Small                30
 * B     Medium               35
 * C     Large                40
 */

import java.util.Arrays;
import javax.swing.JOptionPane;

public class SimpleMealOrderingSystem
{
    public static void main(String[] args)
    {
        final String program_name = "Meal Ordering System";

        String meal_quantity_prompt = "", drink_quantity_prompt = "";
        int meal_quantity, drink_quantity, total_price = 0;
        char meal, drink;
        int orders = 0;

        while (true)  // Enter an infinite loop.
        {
            // ? Ask for meal and drink.
            meal = JOptionPane.showInputDialog(
                null,
                String.format(
                    "Please choose a meal:\n\n%s\n%s\n%s\n%s\n\n%s",
                    "[ A ] Chicken & Spaghetti         150",
                    "[ B ] Hamburger & Fries           145",
                    "[ C ] Cheesedog                   100",
                    "[ D ] Pizza                       80",
                    "[ Q ] Quit"
                )
            ).toLowerCase().toCharArray()[0];

            if (meal == 'q') return;  // Quit if user wants to exit.

            drink = JOptionPane.showInputDialog(
                null,
                String.format(
                    "Please choose a drink:\n\n%s\n%s\n%s\n",
                    "[ A ] Small          30",
                    "[ B ] Medium         35",
                    "[ C ] Large          40"
                )
            ).toLowerCase().toCharArray()[0];

            // ? Check if the order of the user exists in the menu.
            if (
                0 > Arrays.binarySearch(
                    new char[] {'a', 'b', 'c', 'd'}, meal
                ) || 0 > Arrays.binarySearch(
                    new char[] {'a', 'b', 'c'}, drink
                )
            )
            {
                if (
                    JOptionPane.showConfirmDialog(
                        null,
                        "The meal you are ordering is nowhere to be found!\nDo you want to re-order?",
                        program_name,
                        0
                    ) == 1
                ) return;
                continue;
            }

            // ? Build and ask quantity of meals and drinks
            if (meal == 'a') meal_quantity_prompt = "chickens & spaghettis";
            else if (meal == 'b') meal_quantity_prompt = "hamburgers & fries";
            else if (meal == 'c') meal_quantity_prompt = "cheesedogs";
            else if (meal == 'd') meal_quantity_prompt = "pizzas";

            if (drink == 'a') drink_quantity_prompt = "small";
            else if (drink == 'b') drink_quantity_prompt = "medium-sized";
            else if (drink == 'c') drink_quantity_prompt = "large";

            try
            {
                meal_quantity = Integer.parseInt(
                    JOptionPane.showInputDialog(
                        null,
                        String.format(
                            "How many %s do you want?",
                            meal_quantity_prompt
                        )
                    )
                );
                drink_quantity = Integer.parseInt(
                    JOptionPane.showInputDialog(
                        null,
                        String.format(
                            "How many %s drinks do you want?",
                            drink_quantity_prompt
                        )
                    )
                );
            }
            catch (NumberFormatException e)
            {
                JOptionPane.showMessageDialog(null, "Please enter a valid number.", program_name, 0);
                continue;
            }

            // ? Calculate total price
            if (meal == 'a') total_price = meal_quantity * 150;
            else if (meal == 'b') total_price = meal_quantity * 145;
            else if (meal == 'c') total_price = meal_quantity * 100;
            else if (meal == 'd') total_price = meal_quantity * 80;

            if (drink == 'a') total_price += drink_quantity * 30;
            else if (drink == 'b') total_price += drink_quantity * 35;
            else if (drink == 'c') total_price += drink_quantity * 40;

            // ? Print output
            JOptionPane.showMessageDialog(
                null,
                String.format(
                    "Order #%d\n\n- Meal%s: %d %s (Meal %s)\n- Drink%s Size: %d %s (Drink %s)\n\nThe total price is PHP %d.",
                    ++orders,
                    meal_quantity > 1 ? "s" : "", meal_quantity, meal_quantity_prompt, Character.toUpperCase(meal),
                    drink_quantity > 1 ? "s" : "", drink_quantity, drink_quantity_prompt, Character.toUpperCase(drink),
                    total_price
                )
            );

            // ? Ask user if they want to order again.
            if (JOptionPane.showConfirmDialog(
                null,
                "Do you want to re-order?", program_name, 0
            ) == 1) return;
        }
    }
}
