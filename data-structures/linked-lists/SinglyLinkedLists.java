public class SinglyLinkedLists {
    public static void main(String[] args) {
        // Create a new linked list with a single node
        SinglyLinkedListNode head = new SinglyLinkedListNode(2);

        // Add nine more nodes to the list
        SinglyLinkedListNode current = head;
        for (int i = 1; i < 10; i++) {
            // Add a new node to the end of the list
            current.setNext(new SinglyLinkedListNode(current.data * 2));
            current = current.getNext(); // Advance to the newly-created node.
        }

        // Print the list
        current = head;
        int node_count = 0;
        while (current != null) {
            // The output should be a list of powers of two.
            System.out.printf("Node %d: %d\n", node_count++, current.data);
            current = current.getNext();
        }
    }
}

/// This class represents a node in a singly-linked list.
public class SinglyLinkedListNode {
    public int data;
    private SinglyLinkedListNode next;

    /// Create a new node with the given data and null next node.
    public SinglyLinkedListNode(int data) {
        this.data = data;
        this.next = null;
    }

    /// Create a new node with the given data and next node
    public SinglyLinkedListNode(int data, SinglyLinkedListNode next) {
        this.data = data;
        this.next = next;
    }

    /// Get the next node
    public SinglyLinkedListNode getNext() {
        return this.next;
    }

    /// Set the next node
    public void setNext(SinglyLinkedListNode next) {
        this.next = next;
    }
}
