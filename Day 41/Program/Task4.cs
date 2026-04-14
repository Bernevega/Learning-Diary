using System;

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Console.WriteLine("Please enter a number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            decimal result = 50m / number;
            Console.WriteLine($"50 / {number} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong format!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero is not allowed");
        }
        finally
        {
            Console.WriteLine("Division attempt finished");
        }

        Console.WriteLine();
    }
}