using System;

class BankAccount
{
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be greater than 0.");

        Balance += amount;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        BankAccount account = new BankAccount(100m);

        account.Deposit(50m);
        Console.WriteLine($"Balance after valid deposit: {account.Balance}");

        try
        {
            account.Deposit(-10m);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Final balance: {account.Balance}");

        Console.WriteLine();
    }
}