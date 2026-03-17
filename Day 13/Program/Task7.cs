using System;
using System.Collections.Generic;

class Account
{
    public string Username { get; set; }
    public int Id { get; private set; }

    public Account(string username, int id)
    {
        Username = username;
        Id = id;
    }
}

class Task7
{
    public static void TaskSeven()
    {

        Account account1 = new Account("user1", 101);
        Console.WriteLine($"Username: {account1.Username}, Id: {account1.Id}");
        Console.WriteLine();
    }
}