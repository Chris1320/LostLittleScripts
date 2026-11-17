import java.util.ArrayList;
import java.util.Scanner;

class CollectionsSample {
    public static void main(String[] args) {
        var scanner = new Scanner(System.in);

        // Use an ArrayList collection to store the items in the backpack
        var backpack = new ArrayList<String>();

        while (true) {
            System.out.println("\nBackpack Content Tracker");
            System.out.println("\n[A] Add an item");
            System.out.println("[R] Remove an item");
            System.out.println("[V] View all items");
            System.out.println("[Q] Quit");

            System.out.printf("\n\n(%d items in backpack) >>> ", backpack.size());
            var _input = scanner.nextLine().toUpperCase();
            var input = _input.isBlank() ? ' ' : _input.charAt(0);
            switch (input) {
                case 'A':
                    System.out.print("Enter the item to add: ");
                    var new_item = scanner.nextLine();
                    backpack.add(new_item);
                    System.out.printf("%s has been added to the backpack.\n", new_item);
                    break;

                case 'R':
                    System.out.print("Enter the item number to remove: ");
                    var item_number = Integer.parseInt(scanner.nextLine());
                    if (item_number <= 0 || item_number > backpack.size()) {
                        System.out.println("Invalid item number. Please try again.");
                    } else {
                        var removed_item = backpack.remove(item_number - 1);
                        System.out.printf("%s has been removed from the backpack.\n", removed_item);
                    }
                    break;

                case 'V':
                    System.out.println("+ Items in the backpack:");
                    for (int i = 0; i < backpack.size(); i++) {
                        System.out.printf("+ [%d] %s\n", i + 1, backpack.get(i));
                    }
                    break;

                case 'Q':
                    System.out.println("Bye!");
                    scanner.close();
                    return;

                default:
                    System.out.println("Invalid input. Please try again.");
                    break;
            }
        }
    }
}
