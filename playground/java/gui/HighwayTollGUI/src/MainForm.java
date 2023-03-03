import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MainForm
{
    private JLabel title;
    private JRadioButton class1RadioButton;
    private JRadioButton class2RadioButton;
    private JRadioButton class3RadioButton;
    private JTextField km;
    private JButton calculateTotalPriceButton;
    private JTextField result;
    private JPanel main_panel;

    private byte v_class;

    public MainForm(String window_title)
    {
        this.title.setText(window_title);
        class1RadioButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                radioButtonAction((byte) 1);
            }
        });
        class2RadioButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                radioButtonAction((byte) 2);
            }
        });
        class3RadioButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                radioButtonAction((byte) 3);
            }
        });
        calculateTotalPriceButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                btnCalculateTotalCost();
            }
        });
    }

    public JPanel getPanel()
    {
        return this.main_panel;
    }

    private void radioButtonAction(byte v_class)
    {
        this.v_class = v_class;
    }

    private void btnCalculateTotalCost()
    {
        if (km.getText().length() == 0)
        {
            JOptionPane.showMessageDialog(null, "Please enter the distance you will drive.");
            return;
        }

        double total_amount = Double.NaN;
        double km_in_double = Double.parseDouble(km.getText());

        switch (this.v_class)
        {
            case 1 ->
            {
                total_amount = 41 + (km_in_double * 20);
            }
            case 2 ->
            {
                total_amount = 102 + (km_in_double * 35);
            }
            case 3 ->
            {
                total_amount = 122 + (km_in_double * 50);
            }
            default ->
            {
                JOptionPane.showMessageDialog(
                    null,
                    "Please choose a vehicle class."
                );
            }
        }

        if (!Double.isNaN(total_amount)) {
            this.result.setText(String.valueOf(total_amount));
        }
    }
}
