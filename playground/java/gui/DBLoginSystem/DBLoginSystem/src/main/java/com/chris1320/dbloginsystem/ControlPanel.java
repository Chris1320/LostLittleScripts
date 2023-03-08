package com.chris1320.dbloginsystem;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;

public class ControlPanel
{
    private JLabel title;
    private JTextField search_bar;
    private JTextField username;
    private JTextField name_first;
    private JTextField name_middle;
    private JTextField name_last;
    private JTextField password;
    private JTextField course;
    private JButton quitButton;
    private JPanel main_panel;
    private JButton deleteStudentButton;
    private JButton searchButton;
    private Connection connection;

    ControlPanel(JFrame main_frame)
    {
        this.title.setText(Info.NAME);

        // Create connection
        try
        {
            connection = DriverManager.getConnection(
                Info.DB_SERVER_URL,
                Info.DB_CREDENTIALS[0],  // username
                Info.DB_CREDENTIALS[1]  // password
            );
        }
        catch (SQLException e)
        {
            JOptionPane.showMessageDialog(null, "Unable to connect to the database server.");
            return;
        }

        quitButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                backToMenu(main_frame);
            }
        });
        deleteStudentButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                try
                {
                    if (search_bar.getText().length() != 0)
                    {
                        PreparedStatement statement = connection.prepareStatement(
                            String.format("DELETE FROM %s.%s WHERE student_id=?;", Info.DB_NAME, Info.DB_TABLE)
                        );
                        statement.setString(1, search_bar.getText());
                        statement.execute();
                        JOptionPane.showMessageDialog(null, "User removed!");
                        clearTextFields();
                    }
                }
                catch (SQLException ex)
                {
                    JOptionPane.showMessageDialog(null, "Cannot remove student! " + ex.getMessage());
                }
            }
        });
        searchButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                try
                {
                    PreparedStatement statement = connection.prepareStatement(
                        String.format("SELECT * FROM %s.%s WHERE student_id=?;", Info.DB_NAME, Info.DB_TABLE)
                    );
                    statement.setString(1, search_bar.getText());
                    ResultSet search_result = statement.executeQuery();
                    if (!search_result.next()) JOptionPane.showMessageDialog(null, "Student not found.");
                    else
                    {
                        username.setText(search_result.getString("username"));
                        password.setText(search_result.getString("password"));
                        name_first.setText(search_result.getString("first_name"));
                        name_middle.setText(search_result.getString("middle_name"));
                        name_last.setText(search_result.getString("last_name"));
                        course.setText(search_result.getString("course"));
                    }
                }
                catch (SQLException ex)
                {
                    JOptionPane.showMessageDialog(null, "Cannot find student! " + ex.getMessage());
                }
            }
        });
    }

    public void backToMenu(JFrame main_frame)
    {
        main_panel.removeAll();
        main_frame.setContentPane(new LandingPanel(main_frame).getPanel());
        main_frame.validate();  // refresh the frame.
    }

    private void clearTextFields()
    {
        username.setText("");
        password.setText("");
        course.setText("");
        name_first.setText("");
        name_middle.setText("");
        name_last.setText("");
    }

    public JPanel getPanel()
    {
        return this.main_panel;
    }
}
