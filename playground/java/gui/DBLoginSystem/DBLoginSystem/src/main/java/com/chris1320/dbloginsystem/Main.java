package com.chris1320.dbloginsystem;

import javax.swing.JFrame;

public class Main
{
    public static void main(String[] args)
    {
        JFrame main_window = new JFrame(Info.NAME);
        main_window.setContentPane(new LandingPanel(main_window).getPanel());
        main_window.setResizable(false);
        main_window.setSize(Info.WINDOW_SIZE[0], Info.WINDOW_SIZE[1]);
        main_window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        // frame.pack();
        main_window.setVisible(true);
    }
}
