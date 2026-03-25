using System;
using System.Collections.Generic;

class UserAccount
{
    public string Username { get; set; }
    public int PasswordLength { get; set; }

    public UserAccount(string name, int length)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
        {
            Username = "Unknown";
            Console.WriteLine("Invalid username. Storing \"Unknown\"");
            Console.WriteLine();
        }
        else
            Username = name;


        if (length < 6)
        {
            PasswordLength = 6;
            Console.WriteLine("Password too short. Storing 6");
            Console.WriteLine();
        }
        else
            PasswordLength = length;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Hello, {Username}");
        Console.WriteLine($"Your password length is {PasswordLength}");
        Console.WriteLine();
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("--- Task 5 ---");

        UserAccount acc1 = new UserAccount(null, 0);
        UserAccount acc2 = new UserAccount("Da", 7);
        UserAccount acc3 = new UserAccount("David", 3);
        UserAccount acc4 = new UserAccount("David", 10);
        UserAccount acc5 = new UserAccount("   ", 8);

        acc1.PrintInfo();
        acc2.PrintInfo();
        acc3.PrintInfo();
        acc4.PrintInfo();
        acc5.PrintInfo();
    }
}