package com.chris1320.dbloginsystem;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.sql.*;

public class SignUpForm
{
    private JPanel main_panel;
    private JLabel title;
    private JTextField username;
    private JPasswordField password;
    private JPasswordField password_confirm;
    private JButton registerButton;
    private JButton backToMenuButton;
    private JLabel password_mismatch_label;
    private JLabel username_constraint_label;
    private JLabel password_constraint_label;
    private JTextField name_first;
    private JTextField name_middle;
    private JTextField name_last;
    private JRadioButton btn_bsit;
    private JRadioButton btn_bscs;

    private short course = 0;

    Connection connection;

    SignUpForm(JFrame main_frame)
    {
        this.title.setText(Info.NAME);

        // Hide the warnings at start.
        this.password_mismatch_label.setVisible(false);
        this.password_constraint_label.setVisible(false);
        this.password_constraint_label.setText(
            String.format(
                "The password must be %s-%s characters.",
                Info.PASS_LEN[0], Info.PASS_LEN[1]
            )
        );
        this.username_constraint_label.setVisible(false);
        this.username_constraint_label.setText(
            String.format(
                "The username must be %s-%s characters.",
                Info.USER_LEN[0], Info.USER_LEN[1]
            )
        );

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
        }

        backToMenuButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                backToMenu(main_frame);
            }
        });
        username.addKeyListener(new KeyAdapter()
        {
            @Override
            public void keyReleased(KeyEvent e)
            {
                super.keyReleased(e);
                username_constraint_label.setVisible(Utils.checkInvalidUsername(username.getText()));
            }
        });
        password.addKeyListener(new KeyAdapter()
        {
            @Override
            public void keyReleased(KeyEvent e)
            {
                super.keyReleased(e);
                password_constraint_label.setVisible(
                    Utils.checkInvalidPassword(Utils.convertPasswordToString(password.getPassword()))
                );
                password_mismatch_label.setVisible(checkPasswordsMismatch());
            }
        });
        password_confirm.addKeyListener(new KeyAdapter()
        {
            @Override
            public void keyReleased(KeyEvent e)
            {
                super.keyReleased(e);
                // Show the "password mismatch" label when the two passwords are not equal.
                password_constraint_label.setVisible(
                    Utils.checkInvalidPassword(Utils.convertPasswordToString(password.getPassword()))
                );
                password_mismatch_label.setVisible(checkPasswordsMismatch());
            }
        });
        registerButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                if (Utils.checkInvalidUsername(username.getText()))
                {
                    JOptionPane.showMessageDialog(null, "Invalid username!");
                    return;
                }
                else if (Utils.checkInvalidPassword(Utils.convertPasswordToString(password.getPassword())))
                {
                    JOptionPane.showMessageDialog(null, "Invalid password!");
                    return;
                }
                else if (checkPasswordsMismatch())
                {
                    JOptionPane.showMessageDialog(null, "Passwords does not match!");
                    return;
                }
                else if (name_first.getText().length() == 0 || name_last.getText().length() == 0)
                {
                    JOptionPane.showMessageDialog(null, "Please enter your name.");
                    return;
                }
                else if (course == 0)
                {
                    JOptionPane.showMessageDialog(null, "Please select your course.");
                    return;
                }
                try
                {
                    // Get the latest student ID.
                    int latest_id;
                    Statement latest_id_statement = connection.createStatement();
                    latest_id_statement.execute(
                        String.format(
                            "SELECT MAX(student_id) FROM %s.%s",
                            Info.DB_NAME,
                            Info.DB_TABLE
                        )
                    );
                    ResultSet latest_id_statement_result = latest_id_statement.getResultSet();

                    if (latest_id_statement_result.next())
                    {
                        try
                        {
                            latest_id = Integer.parseInt(latest_id_statement_result.getString(1));
                            latest_id++;
                        }
                        catch (NumberFormatException ex)
                        {
                            latest_id = 1;
                        }
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(null, "Cannot get student ID.");
                        return;
                    }

                    PreparedStatement dupe_user_statement = connection.prepareStatement(
                        "SELECT username FROM users WHERE username=?"
                    );
                    dupe_user_statement.setString(1, username.getText());
                    ResultSet dupe_user_statement_result = dupe_user_statement.executeQuery();
                    if (dupe_user_statement_result.next())
                    {
                        JOptionPane.showMessageDialog(null, "Username already exists!");
                        return;
                    }

                    // Add the record to the database.
                    Statement statement = connection.createStatement();
                    statement.execute(
                        String.format(
                            "INSERT INTO %s.%s VALUES ('%s', '%s', '%s', '%s', '%s', '%s', '%s')",
                            Info.DB_NAME,
                            Info.DB_TABLE,
                            latest_id,
                            username.getText(),
                            Utils.convertPasswordToString(password.getPassword()),
                            name_first.getText(),
                            name_middle.getText(),
                            name_last.getText(),
                            Utils.getCourse(course)
                        )
                    );

                    JOptionPane.showMessageDialog(null, "You have successfully registered!");
                    backToMenu(main_frame);
                }
                catch (SQLException | NullPointerException ex)
                {
                    JOptionPane.showMessageDialog(
                        null,
                        "Unable to submit your registration: " + ex.getMessage()
                    );
                }
            }
        });
        btn_bsit.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                course = 1;
            }
        });
        btn_bscs.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                course = 2;
            }
        });
    }

    public boolean checkPasswordsMismatch()
    {
        return !Utils.convertPasswordToString(
            password.getPassword()
        ).equals(
            Utils.convertPasswordToString(password_confirm.getPassword()
            ));
    }

    public void backToMenu(JFrame main_frame)
    {
        main_frame.setContentPane(new LandingPanel(main_frame).getPanel());
        main_frame.validate();  // refresh the frame.
    }

    public JPanel getPanel()
    {
        return this.main_panel;
    }
}
