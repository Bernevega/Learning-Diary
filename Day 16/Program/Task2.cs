using System;
using System.Collections.Generic;

class BankAccount
{
    public string Owner { get; set; }
    private double balance;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Your have deposited {amount}€ to your account.");
        }
        else
            Console.WriteLine("You cannot deposit less than 0€!");

        Console.WriteLine();
    }
    public void Withdraw(double amount)
    {
        if (amount < balance && amount > 0)
        {
            balance -= amount;
            Console.WriteLine($"Your have withdrawn {amount}€ from your account.");
        }
        else
            Console.WriteLine("You cannot withdraw more than you have in your account!");

        Console.WriteLine();
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Hello, {Owner}!");
        Console.WriteLine($"Your balance: {balance}€.");

        Console.WriteLine();
    }
}


class Task2
{
    public static void TaskTwo()
    {
        BankAccount account1 = new BankAccount();
        account1.Owner = "Rose";
        account1.Deposit(1000);
        account1.ShowBalance();
        account1.Withdraw(3000);
        account1.Deposit(5000);
        account1.Withdraw(3000);
        account1.ShowBalance();
    }
}

