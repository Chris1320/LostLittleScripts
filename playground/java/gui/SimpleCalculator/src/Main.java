import javax.swing.JFrame;

public class Main
{
    public static void main(String[] args)
    {
        JFrame frame = new JFrame(Info.NAME);  // Create a new JFrame.
        frame.setContentPane(new MainWindow().getPanel());  // Get JPanel from MainWindow().

        // Set JFrame attributes.
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setResizable(false);
        frame.setVisible(true);
    }
}
