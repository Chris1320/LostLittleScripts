import javax.swing.*;
import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Main
{
    public static void main(String[] args)
    {
        final String NAME = "Calculator";
        CalculatorMemory memory = new CalculatorMemory();

        // Set up the main frame and panel.
        JFrame main_frame = new JFrame(NAME);
        JPanel main_panel = new JPanel();

        main_frame.setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
        main_frame.setSize(300, 500);
        main_panel.setLayout(new BorderLayout());

        // Initialize panels to use.
        JPanel output = new JPanel();
        JPanel keypad = new JPanel();

        output.setLayout(new FlowLayout());
        keypad.setLayout(new GridLayout(5, 4, 5, 5));

        // Create the output panel.
        JTextField output_area = new JTextField();
        output_area.setFont(new Font("Arial", Font.PLAIN, 50));
        output_area.setEditable(false);
        output.add(output_area);

        // Create the keypad.
        JButton keypad_num0 = new JButton("0");
        JButton keypad_num1 = new JButton("1");
        JButton keypad_num2 = new JButton("2");
        JButton keypad_num3 = new JButton("3");
        JButton keypad_num4 = new JButton("4");
        JButton keypad_num5 = new JButton("5");
        JButton keypad_num6 = new JButton("6");
        JButton keypad_num7 = new JButton("7");
        JButton keypad_num8 = new JButton("8");
        JButton keypad_num9 = new JButton("9");

        JButton keypad_add = new JButton("+");
        JButton keypad_sub = new JButton("-");
        JButton keypad_mul = new JButton("*");
        JButton keypad_div = new JButton("/");

        JButton keypad_del = new JButton("DEL");
        JButton keypad_clr = new JButton("CLR");
        JButton keypad_dot = new JButton(".");
        JButton keypad_equ = new JButton("=");

        // Add functionality to the buttons.
        keypad_num0.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "0"));
        keypad_num1.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "1"));
        keypad_num2.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "2"));
        keypad_num3.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "3"));
        keypad_num4.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "4"));
        keypad_num5.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "5"));
        keypad_num6.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "6"));
        keypad_num7.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "7"));
        keypad_num8.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "8"));
        keypad_num9.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "9"));

        keypad_add.addActionListener(KeypadActionFactory.updateMemory(memory, output_area, (byte) 1));
        keypad_sub.addActionListener(KeypadActionFactory.updateMemory(memory, output_area, (byte) 2));
        keypad_mul.addActionListener(KeypadActionFactory.updateMemory(memory, output_area, (byte) 3));
        keypad_div.addActionListener(KeypadActionFactory.updateMemory(memory, output_area, (byte) 4));

        keypad_del.addActionListener(
            new ActionListener()
            {
                @Override
                public void actionPerformed(ActionEvent e)
                {
                    // FIXME: This will create unwanted behavior when operators are removed.
                    output_area.setText(
                        output_area.getText().substring(0, output_area.getText().length() - 1)
                    );
                    memory.input = memory.input.substring(0, memory.input.length() - 1);
                }
            }
        );
        keypad_clr.addActionListener(
            new ActionListener()
            {
                @Override
                public void actionPerformed(ActionEvent e)
                {
                    output_area.setText("");
                    memory.clear();
                }
            }
        );
        keypad_dot.addActionListener(KeypadActionFactory.updateOutputArea(memory, output_area, "."));
        keypad_equ.addActionListener(KeypadActionFactory.updateMemory(memory, output_area, (byte) 5));

        // Format: from top-left to bottom-right
        keypad.add(new JPanel());
        keypad.add(new JPanel());
        keypad.add(keypad_del);
        keypad.add(keypad_clr);

        keypad.add(keypad_num7);
        keypad.add(keypad_num8);
        keypad.add(keypad_num9);
        keypad.add(keypad_div);

        keypad.add(keypad_num4);
        keypad.add(keypad_num5);
        keypad.add(keypad_num6);
        keypad.add(keypad_mul);

        keypad.add(keypad_num1);
        keypad.add(keypad_num2);
        keypad.add(keypad_num3);
        keypad.add(keypad_sub);

        keypad.add(keypad_num0);  // 0 will have double grids occupied.
        keypad.add(keypad_dot);
        keypad.add(keypad_equ);
        keypad.add(keypad_add);

        // Add the panels to the main panel.
        main_panel.add(output_area, BorderLayout.NORTH);
        main_panel.add(keypad, BorderLayout.CENTER);

        // Add the main panel to the main frame.
        main_frame.add(main_panel);

        // Make the main frame visible.
        main_frame.setVisible(true);
    }
}
