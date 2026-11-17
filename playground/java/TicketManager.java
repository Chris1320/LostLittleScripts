import java.util.HashMap;
import java.util.Scanner;
import java.util.Map;

enum Status {
    PENDING, IN_PROGRESS, COMPLETED
}

class Ticket {
    final String title;
    final String description;
    final Status status;

    public Ticket(String title, String description, Status status) {
        this.title = title;
        this.description = description;
        this.status = status;
    }
}

class TicketManager {
    static Status getStatusFromInput(Scanner scanner, String prompt) {
        while (true) {
            System.out.print(prompt);
            var status_input = scanner.nextLine().toUpperCase();
            try {
                return Status.valueOf(status_input);
            } catch (IllegalArgumentException e) {
                System.out.println("Invalid status. Please try again.");
            }
        }
    }

    public static void main(String[] args) {
        var scanner = new Scanner(System.in);
        Map<String, Ticket> tickets = new HashMap<>();

        while (true) {
            System.out.println("\nTicket Manager");
            System.out.println("\n[A] Add a ticket");
            System.out.println("[U] Update a ticket");
            System.out.println("[R] Remove a ticket");
            System.out.println("[V] View all items");
            System.out.println("[Q] Quit");

            System.out.printf("\n\n(%d tickets present) >>> ", tickets.size());
            var _input = scanner.nextLine().toUpperCase();
            var input = _input.isBlank() ? ' ' : _input.charAt(0);
            switch (input) {
                case 'A':
                    System.out.print("Enter the ticket ID: ");
                    var ticket_id_to_add = scanner.nextLine();
                    System.out.print("Enter the ticket title: ");
                    var title = scanner.nextLine();
                    System.out.print("Enter the ticket description: ");
                    var description = scanner.nextLine();
                    var status = getStatusFromInput(scanner,
                            "Enter the ticket status (PENDING, IN_PROGRESS, COMPLETED): ");
                    var ticket_to_add = new Ticket(title, description, status);
                    tickets.put(ticket_id_to_add, ticket_to_add);
                    break;

                case 'U':
                    System.out.print("Enter the ticket ID to update: ");
                    var ticket_id_to_update = scanner.nextLine();
                    try {
                        var ticket_to_update = tickets.get(ticket_id_to_update);
                        System.out.printf("Enter the new ticket title (%s): ", ticket_to_update.title);
                        var new_title = scanner.nextLine();
                        System.out.printf("Enter the new ticket description (%s): ", ticket_to_update.description);
                        var new_description = scanner.nextLine();
                        var new_status = getStatusFromInput(scanner, String.format("Enter the new ticket status (%s): ",
                                ticket_to_update.status));
                        var new_ticket = new Ticket(new_title.isBlank() ? ticket_to_update.title : new_title,
                                new_description.isBlank() ? ticket_to_update.description : new_description,
                                new_status);
                        tickets.replace(ticket_id_to_update, new_ticket);
                        System.out.printf("Ticket %s has been updated.\n", ticket_id_to_update);
                    } catch (NullPointerException e) {
                        System.out.println("Ticket not found. Please try again.");
                    }
                    break;

                case 'R':
                    System.out.print("Enter the ticket ID to remove: ");
                    var ticket_id_to_remove = scanner.nextLine();
                    try {
                        tickets.remove(ticket_id_to_remove);
                        System.out.printf("Ticket %s has been removed.\n", ticket_id_to_remove);
                    } catch (NullPointerException e) {
                        System.out.println("Ticket not found. Please try again.");
                    }
                    break;

                case 'V':
                    System.out.println("+ Tickets present:");
                    tickets.forEach((id, ticket_data) -> {
                        System.out.printf("+ [%s] %s - %s (%s)\n", id, ticket_data.title, ticket_data.description,
                                ticket_data.status);
                    });
                    System.out.println();
                    break;

                case 'Q':
                    System.out.println("Bye!");
                    scanner.close();
                    return;
            }
        }
    }
}
