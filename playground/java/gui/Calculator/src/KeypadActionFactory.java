import javax.swing.JTextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class KeypadActionFactory
{
    public static ActionListener updateOutputArea(CalculatorMemory memory, JTextField output_area, String str_to_add)
    {
        return new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                memory.input = String.format("%s%s", memory.input, str_to_add);
                output_area.setText(String.format(
                    "%s%s", output_area.getText(), str_to_add
                ));
            }
        };
    }

    public static ActionListener updateMemory(CalculatorMemory memory, JTextField output_area, byte current_operation)
    {
        return new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                char[] operations = {'+', '-', '*', '/', '='};

                if (current_operation == 5)  // If `=` is pressed, perform the final operation.
                {
                    switch (memory.operation)
                    {
                        case 1 -> memory.prev_input = memory.prev_input + Double.parseDouble(memory.input);
                        case 2 -> memory.prev_input = memory.prev_input - Double.parseDouble(memory.input);
                        case 3 -> memory.prev_input = memory.prev_input * Double.parseDouble(memory.input);
                        case 4 -> memory.prev_input = memory.prev_input / Double.parseDouble(memory.input);
                        default -> memory.prev_input = Double.parseDouble(memory.input);
                    }
                    output_area.setText(memory.prev_input.toString());

                    // Clear memory.
                    memory.operation = 0;
                    memory.input = "";
                    return;
                }
                switch (memory.operation)
                {
                    case 1 ->
                    {
                        memory.prev_input += Double.parseDouble(memory.input);
                        memory.input = "";
                    }
                    case 2 ->
                    {
                        memory.prev_input -= Double.parseDouble(memory.input);
                        memory.input = "";
                    }
                    case 3 ->
                    {
                        memory.prev_input *= Double.parseDouble(memory.input);
                        memory.input = "";
                    }
                    case 4 ->
                    {
                        memory.prev_input /= Double.parseDouble(memory.input);
                        memory.input = "";
                    }
                    default ->
                    {
                        if (memory.input.length() != 0) memory.prev_input = Double.parseDouble(memory.input);
                        memory.input = "";
                    }
                }
                memory.operation = current_operation;
                output_area.setText(String.format("%s%s", output_area.getText(), operations[current_operation - 1]));
            }
        };
    }
}
