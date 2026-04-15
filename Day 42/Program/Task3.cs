using System;

class Task3
{
    public static void Register(string username, int age)
    {
        if (username == null)
            throw new ArgumentNullException(nameof(username));
        else if (username.Length < 3)
            throw new ArgumentException("The username cannot be less than 3 symbols");
        else if (age < 0 || age > 120)
            throw new ArgumentOutOfRangeException(nameof(age), "The age must be between 0 and 120");

        Console.WriteLine("User registered successfully");
    }

    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        try
        {
            Register("Bob", 56);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Register(null, 20);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Register("Alex", -16);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
    }
}