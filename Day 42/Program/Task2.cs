using System;
class Task2
{
    public static void DivideNumbers(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by 0!");

        Console.WriteLine($"{a} / {b} = { a / b}");
    }
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        try
        {
            DivideNumbers(5, 1);
            DivideNumbers(5, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
    }
}