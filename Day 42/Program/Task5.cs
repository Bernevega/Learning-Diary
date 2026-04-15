using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public decimal Balance { get; set; }

    public BankAccount(decimal balance)
    {
        Balance = balance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "The withdrawn amount cannot be 0 or less");
        else if (amount > Balance)
            throw new InsufficientFundsException("Cannot withdraw more than there is on your balance");

        Balance -= amount;
        Console.WriteLine($"Your balance: {Balance}");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        BankAccount account = new BankAccount(500);

        try
        {
            account.Withdraw(400);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            account.Withdraw(0);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            account.Withdraw(500);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
    }
}