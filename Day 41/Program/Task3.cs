using System;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Console.WriteLine("Please enter a number:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} * 2 = {number * 2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong format!");
        }
        finally
        {
            Console.WriteLine("Task complete");
        }

        Console.WriteLine();
    }
}