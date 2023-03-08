package com.chris1320.dbloginsystem;

public class Utils
{
    public static String convertPasswordToString(char[] password)
    {
        StringBuilder result = new StringBuilder();
        for (char c : password) result.append(c);
        return result.toString();
    }

    /**
     * Check if the entered username is within constraints.
     *
     * @param username The username to check.
     * @return true if the password is valid.
     */
    public static boolean checkInvalidUsername(String username)
    {
        return username.length() < Info.USER_LEN[0] || username.length() > Info.USER_LEN[1];
    }

    /**
     * Check if the entered password is within constraints.
     *
     * @param password The password to check.
     * @return true if the password is valid.
     */
    public static boolean checkForInvalidPassword(String password)
    {
        return password.length() < Info.PASS_LEN[0] || password.length() > Info.PASS_LEN[1];
    }

    public static String getCourse(short course)
    {
        if (course == 1) return "BSIT";
        else return "BSCS";
    }
}
