import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class MainWindow
{
    private JTextField num1;
    private JTextField num2;
    private JButton subtractButton;
    private JButton multiplyButton;
    private JButton divideButton;
    private JButton addButton;
    private JLabel label_x;
    private JLabel label_y;
    private JLabel title;
    private JTextField result;
    private JPanel main_panel;

    public MainWindow()
    {
        title.setText(Info.NAME);

        addButton.addActionListener(
            e -> result.setText(String.valueOf(Double.parseDouble(num1.getText()) + Double.parseDouble(num2.getText())))
        );
        subtractButton.addActionListener(
            e -> result.setText(String.valueOf(Double.parseDouble(num1.getText()) - Double.parseDouble(num2.getText())))
        );
        multiplyButton.addActionListener(
            e -> result.setText(String.valueOf(Double.parseDouble(num1.getText()) * Double.parseDouble(num2.getText())))
        );
        divideButton.addActionListener(
            e -> result.setText(String.valueOf(Double.parseDouble(num1.getText()) / Double.parseDouble(num2.getText())))
        );
    }

    public JPanel getPanel()
    {
        return this.main_panel;
    }

    private void createUIComponents()
    {
        // TODO: place custom component creation code here
    }

}
