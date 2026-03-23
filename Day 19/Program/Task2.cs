using System;
using System.Collections.Generic;

class BankAccount
{
    private double balance;
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} was added to your account!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Error!");
            Console.WriteLine();
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Your balance: {balance}€");
        Console.WriteLine();
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal must be greater than 0!");
            Console.WriteLine();
        }
        else if (amount > balance)
        {
            Console.WriteLine("Withdrawal cannot be bigger than current balance!");
            Console.WriteLine();
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"{amount} was withdrawn from your account!");
            Console.WriteLine();
        }
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount();

        acc1.Deposit(100);
        acc1.ShowBalance();

        acc2.Deposit(0);
        acc2.ShowBalance();

        acc1.Withdraw(10);
        acc1.ShowBalance();

        acc2.Withdraw(-1000);
        acc2.ShowBalance();
    }
}