import javax.swing.JFrame;

public class Main
{
    public static void main(String[] args)
    {
        final String NAME = "Highway Toll GUI";

        JFrame main_frame = new JFrame(NAME);

        main_frame.setContentPane(new MainForm(NAME).getPanel());
        main_frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        main_frame.pack();
        main_frame.setVisible(true);
    }
}
