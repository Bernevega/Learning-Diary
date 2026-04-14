using System;

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");

        Console.WriteLine("Program started");
        try
        {
            int integer = int.Parse("25");
            Console.WriteLine(integer);
        }
        catch 
        {
            Console.WriteLine("Error happened");
        }
        finally
        {
            Console.WriteLine("Program ended");
        }

        Console.WriteLine();
    }
}