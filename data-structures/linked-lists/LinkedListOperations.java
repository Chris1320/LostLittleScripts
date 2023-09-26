public class LinkedListOperations {
    public static void main(String[] args) {
        // Create a new linked list with a single node
        int node_count = 0;
        DoublyLinkedListNode head = new DoublyLinkedListNode(2);

        // Add nine more nodes to the list
        DoublyLinkedListNode current = head;
        for (int i = 1; i < 10; i++) {
            // Add a new node to the end of the list
            current.setNext(new DoublyLinkedListNode(current.data * 2));
            current.getNext().setPrev(current); // Set the previous node
            current = current.getNext(); // Advance to the newly-created node.
        }

        // Print the list
        current = head;
        while (true) {
            // The output should be a list of powers of two.
            System.out.printf("Node %d: %d\n", node_count++, current.data);
            if (current.getNext() == null) break;
            current = current.getNext();
        }

        // Print the list in reverse
        System.out.println("Traversing the linked list in reverse...");
        while (current != null) {
            System.out.printf("Node %d: %d\n", --node_count, current.data);
            current = current.getPrev();
        }

        // Remove the third node
        System.out.println("Removing all odd nodes...");
        current = head;
        node_count = 0;
        while (true) {
            if (node_count++ % 2 == 1) current.getPrev().setNext(current.getNext());
            if (current.getNext() == null) break;
            current = current.getNext();
        }

        // Print the list
        current = head;
        node_count = 0;
        while (true) {
            // The output should be a list of powers of two, with the third
            // node missing.
            System.out.printf("Node %d: %d\n", node_count++, current.data);
            if (current.getNext() == null) break;
            current = current.getNext();
        }

        // Search for 128 in the linked list.
        System.out.println("Searching for node with value of 128...");
        current = head;
        node_count = 0;
        while (true) {
            if (current.data == 128) {
                System.out.printf("Found node %d: %d\n", node_count, current.data);
                break;
            }
            if (current.getNext() == null) {
                System.out.println("Node with value of 128 not found.");
                break;
            }
            current = current.getNext();
            node_count++;
        }
    }
}

/// This class represents a node in a singly-linked list.
public class DoublyLinkedListNode {
    public int data;
    private DoublyLinkedListNode prev;
    private DoublyLinkedListNode next;

    /// Create a new node with the given data and null next node.
    public DoublyLinkedListNode(int data) {
        this.data = data;
        this.prev = null;
        this.next = null;
    }

    /// Get the next node
    public DoublyLinkedListNode getNext() {return this.next;}

    /// Set the next node
    public void setNext(DoublyLinkedListNode next) {this.next = next;}

    /// Get the previous node
    public DoublyLinkedListNode getPrev() {return this.prev;}

    /// Set the previous node
    public void setPrev(DoublyLinkedListNode prev) {this.prev = prev;}
}
