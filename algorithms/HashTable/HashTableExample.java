import java.util.Hashtable;
import java.util.Enumeration;

public class HashTableExample
{
    public static void main(String[] args)
    {
        // Create a hash table of 10 students.
        Hashtable<Integer, String> students = new Hashtable<>(10);

        // Add some students.
        students.put(1247, "Alice");
        students.put(2651, "Bob");
        students.put(3984, "Charlie");
        students.put(5123, "Diana");
        students.put(6123, "Eve");

        // Print the students.
        Enumeration<Integer> ids = students.keys();
        System.out.println("Students:");
        while (ids.hasMoreElements()) {
            int id = ids.nextElement();
            System.out.printf("    %d: %s\n", id, students.get(id));
        }
    }
}
