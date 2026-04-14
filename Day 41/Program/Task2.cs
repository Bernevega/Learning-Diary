using System;
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        try
        {
            int.Parse("hello");
        }
        catch
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Finished attempt");
        }

        Console.WriteLine();
    }
}