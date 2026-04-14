using System;

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Console.WriteLine("Please enter a number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            decimal result = 100m / number;
            Console.WriteLine($"100 / {number} = {result}");
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
            Console.WriteLine("End of program section");
        }

        Console.WriteLine();
    }
}