using System;
using System.Collections.Generic;

class BankAccount
{
    public string OwnerName { get; set; }
    public double Balance { get; set; }
    public double Loan { get; set; }

    public double NetWorth
    {
        get
        {
            return Balance - Loan;
        }
    }
}

class Task8
{
    public static void TaskEight()
    {
        Console.WriteLine("--- Task 8 ---");

        BankAccount acc1 = new BankAccount();
        acc1.OwnerName = "Karl";
        acc1.Balance = 1000;
        acc1.Loan = 0;
        Console.WriteLine($"{acc1.OwnerName} has a networth of {acc1.NetWorth}.");
        Console.WriteLine();

        BankAccount acc2 = new BankAccount();
        acc2.OwnerName = "Markus";
        acc2.Balance = 0;
        acc2.Loan = 1000;
        Console.WriteLine($"{acc2.OwnerName} has a networth of {acc2.NetWorth}.");
        Console.WriteLine();
    }
}