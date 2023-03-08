package com.chris1320.dbloginsystem;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class LandingPanel
{
    private JPanel main_panel;
    private JLabel title;
    private JButton loginButton;
    private JButton signUpButton;
    private JLabel notice;

    public LandingPanel(JFrame main_frame)
    {
        this.title.setText(Info.NAME);

        signUpButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                main_frame.setContentPane(new SignUpForm(main_frame).getPanel());
                main_frame.validate();  // refresh the frame.
            }
        });
        loginButton.addActionListener(new ActionListener()
        {
            @Override
            public void actionPerformed(ActionEvent e)
            {
                main_frame.setContentPane(new LoginForm(main_frame).getPanel());
                main_frame.validate();
            }
        });
    }

    public JPanel getPanel()
    {
        return this.main_panel;
    }
}
