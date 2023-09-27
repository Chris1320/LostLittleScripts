import java.util.Arrays;

public class QueueExample {
    public static void main(String[] args) {
        // Create a queue of size 5.
        Queue queue = new Queue(5);

        System.out.printf("isEmpty: %b\n", queue.isEmpty());
        // Add 4 items to the queue.
        int n = 5;
        for (int i = 0; i < 4; i++) {
            System.out.printf("Enqueueing %d...\n", n);
            queue.enqueue(n);
            n *= 5;
        }
        System.out.printf("isFull: %b\n", queue.isFull());
        System.out.printf(
            "Data: %s (%s)\n",
            Arrays.toString(queue._getData()),
            Arrays.toString(queue._getAllData())
        );
        System.out.printf("Peek: %d\n", queue.peek());
        // Dequeue 3 items from the queue.
        for (int i = 0; i < 3; i++)
            System.out.printf("Dequeueing %d...\n", queue.dequeue());
        // Add 2 items to the queue.
        System.out.println("Adding 2 items...");
        queue.enqueue(100);
        queue.enqueue(200);
        System.out.printf(
            "Data: %s (%s)\n",
            Arrays.toString(queue._getData()),
            Arrays.toString(queue._getAllData())
        );
        System.out.printf("Peek: %d\n", queue.peek());
    }
}

public class Queue {
    private int[] data;
    private int free, head = 0, tail = 0;

    public Queue(int size) {
        // Define the size of the queue.
        data = new int[size];
        free = size;
    }

    /// Add an item to the queue.
    public void enqueue(int item) {
        data[tail] = item;  // Add the item to the end of the queue.
        tail = (tail + 1) % data.length;  // Increment tail, looping if exceeds array size.
        free--;  // Decrement free space.
    }

    /// Remove an item from the queue and return its value.
    public int dequeue() {
        int item = data[head];  // Get the item at the front of the queue.
        head = (head + 1) % data.length;  // Increment head, looping if exceeds array size.
        free++;  // Increment free space.
        return item;
    }

    public int peek() {return data[head];}  // Get the item at the front of the queue.
    public boolean isFull() {return free == 0;}  // Check if the queue is full.
    public boolean isEmpty() {return free == data.length;}  // Check if the queue is empty.
    public int[] _getAllData() {return data;}  // Get all the data in the queue.
    // Get the data in the queue, excluding free space.
    public int[] _getData() {
        int content = data.length - free;
        int[] result = new int[content];
        for (int i = 0; i < content; i++)
            result[i] = data[(head + i) % data.length];
        return result;
    }
}
