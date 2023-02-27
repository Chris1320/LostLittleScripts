import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.WindowConstants;

public class Main
{
    public static void main(String[] args)
    {
        // Create a new window/frame component.
        JFrame frame = new JFrame("First Java GUI Program");
        JPanel panel = new JPanel();  // Create a new panel component.
        JLabel message = new JLabel("Hello, World!");  // Create a label component.

        panel.add(message);  // Add the label to the panel.
        frame.add(panel);    // Add the panel to the frame.

        frame.setSize(350, 100);  // Set the size of its window.
        // Make the program exit when the close button is clicked.
        frame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        frame.setVisible(true);  // Make its window visible.
    }
}
