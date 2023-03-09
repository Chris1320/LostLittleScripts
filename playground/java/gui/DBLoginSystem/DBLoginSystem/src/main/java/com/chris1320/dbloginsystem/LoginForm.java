package com.chris1320.dbloginsystem;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.sql.*;

public class LoginForm
{
    private JPanel main_panel;
    private JLabel title;
    private JTextField username;
    private JPasswordField password;
    private JButton logInButton;
    private JButton backToMenuButton;

    Connection connection;

    LoginForm(JFrame main_frame)
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
        }

        logInButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                logIn(main_frame);
            }
        });
        backToMenuButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                backToMenu(main_frame);
            }
        });
        password.addKeyListener(new KeyAdapter()
        {
            @Override
            public void keyPressed(KeyEvent e)
            {
                super.keyPressed(e);
                if (e.getKeyCode() == KeyEvent.VK_ENTER)
                {
                    logIn(main_frame);
                }
            }
        });
        username.addKeyListener(new KeyAdapter()
        {
            @Override
            public void keyPressed(KeyEvent e)
            {
                super.keyPressed(e);
                if (e.getKeyCode() == KeyEvent.VK_ENTER)
                {
                    logIn(main_frame);
                }
            }
        });
    }

    public void logIn(JFrame main_frame)
    {
        try
        {
            PreparedStatement get_username_statement = connection.prepareStatement(
                "SELECT password FROM users WHERE username=?"
            );

            get_username_statement.setString(1, username.getText());
            ResultSet get_username_statement_result = get_username_statement.executeQuery();
            if (!get_username_statement_result.next())
            {
                JOptionPane.showMessageDialog(null, "Invalid username/password!");
                return;
            }

            String user_pass = get_username_statement_result.getString(1);

            if (user_pass.equals(Utils.convertPasswordToString(password.getPassword())))
            {
                JOptionPane.showMessageDialog(null, "Logged in!");
                main_frame.setContentPane(new ControlPanel(main_frame).getPanel());
                main_frame.validate();
            }
            else
            {
                JOptionPane.showMessageDialog(null, "Invalid username/password!");
            }
        }
        catch (SQLException | NullPointerException ex)
        {
            JOptionPane.showMessageDialog(null, "Unable to log in.");
        }
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
