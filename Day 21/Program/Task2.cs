using System;
using System.Collections.Generic;

class BankAccount
{
    public string OwnerName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string name, double balance)
    {
        OwnerName = name;
        if (balance < 0)
            Balance = 0;
        else
            Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Cannot deposit 0€ or less");
            Console.WriteLine();
        }
        else
        {
            Balance += amount;
            Console.WriteLine($"{OwnerName} deposited {amount}€ into their account");
            Console.WriteLine();
        }
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Cannot withdraw 0€ or less");
            Console.WriteLine();
        }
        else if (amount > Balance)
        {
            Console.WriteLine($"Cannot withdraw more than on the balance");
            Console.WriteLine();
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"{OwnerName} withdrew {amount}€ from their account");
            Console.WriteLine();
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Hello, {OwnerName}");
        Console.WriteLine($"Your balance: {Balance}");
        Console.WriteLine();
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");

        BankAccount bank1 = new BankAccount("Sherry", -1000);
        bank1.PrintInfo();
        bank1.Deposit(-10);
        bank1.PrintInfo();
        bank1.Deposit(100000);
        bank1.PrintInfo();

        bank1.Withdraw(-10);
        bank1.PrintInfo();
        bank1.Withdraw(10000000);
        bank1.PrintInfo();
        bank1.Withdraw(100);
        bank1.PrintInfo();
    }
}