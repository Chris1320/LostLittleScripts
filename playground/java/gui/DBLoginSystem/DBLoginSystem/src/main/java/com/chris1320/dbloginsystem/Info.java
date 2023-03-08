package com.chris1320.dbloginsystem;

public class Info
{
    final public static String NAME = "Database Login System";
    final public static int[] WINDOW_SIZE = {900, 700};  // width, length

    final public static int[] USER_LEN = {3, 25};  // format: minimum, maximum
    final public static int[] PASS_LEN = {8, 20};

    final public static String DB_SERVER_HOST = "localhost";
    final public static int DB_SERVER_PORT = 32513;
    final public static String DB_NAME = "login_records";
    final public static String DB_TABLE = "users";
    final public static String[] DB_CREDENTIALS = {"root", "root"};

    final public static String DB_SERVER_URL = String.format(
        "jdbc:mysql://%s:%s/%s",
        DB_SERVER_HOST,
        DB_SERVER_PORT,
        DB_NAME
    );
}
