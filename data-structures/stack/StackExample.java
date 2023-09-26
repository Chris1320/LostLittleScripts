public class StackExample {
   public static void main(String[] args) {
      // Create a new stack object that can hold 10 integers.
      Stack stack = new Stack(10);

      System.out.printf("Stack emptiness: %b\n", stack.isEmpty());

      // Push some values onto the stack.
      int n = 2;
      for (int i = 0; i < 10; i++) {
         stack.push(n);
         System.out.printf(
            "Pushed %d onto the stack. (isFull = %s)\n",
            n, stack.isFull()
         );
         n *= 2;
      }

      System.out.printf("Stack emptiness: %b\n", stack.isEmpty());
      System.out.println("Top of the stack: " + stack.peek());

      // Pop 4 values off the stack.
      for (int i = 0; i < 4; i++) System.out.printf("Popped %d off the stack.\n", stack.pop());
      System.out.println("Latest top of the stack: " + stack.peek());
   }
}

// This class represents a stack of integers
public class Stack {
   private int[] data;
   private int cursor = 0; // Index of the next available slot

   Stack(int stack_size) {this.data = new int[stack_size];}

   // Push a value onto the stack
   public void push(int value) {
      if (this.cursor == this.data.length)
         throw new RuntimeException("Stack is full");
      this.data[this.cursor++] = value;
   }

   // Pop a value off the stack
   public int pop() {
      if (this.cursor == 0)
         throw new RuntimeException("Stack is empty");
      return this.data[--this.cursor];
   }

   // Peek at the top of the stack
   public int peek() {return this.data[this.cursor - 1];}

   // Check if the stack is full.
   public boolean isFull() {return this.cursor == this.data.length;}

   // Check if the stack is empty.
   public boolean isEmpty() {return this.cursor == 0;}
}
