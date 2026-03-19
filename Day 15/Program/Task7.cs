using System;
using System.Collections.Generic;

class BankAccount
{
    public string OwnerName { get; set; }
    private double balance;
    public double Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
                balance = value;
            else
                balance = 0;

        }
    }
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Hello, {OwnerName}. {amount}€ was added to your account. Current balance: {Balance}€.");
    }

    public void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine($"Hello, {OwnerName}. {amount}€ was withdrawn from your account. Current balance: {Balance}€.");
    }
}

class Task7
{
    public static void TaskSeven()
    {
        BankAccount account1 = new BankAccount();
        account1.OwnerName = "Mark";
        account1.Balance = 1000;
        account1.Deposit(50);
        account1.Withdraw(150);

        Console.WriteLine();
    }
}