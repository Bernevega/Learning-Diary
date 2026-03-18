using System;
using System.Collections.Generic;

class Account
{
    private double balance;
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }
}

class Task7
{
    public static void TaskSeven()
    {
        Account account1 = new Account();
        account1.Balance = 0;
        Console.WriteLine($"Your balance is; {account1.Balance}");
        Console.WriteLine();
    }
}