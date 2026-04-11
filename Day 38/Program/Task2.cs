using System;
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        object int1 = 1;
        if (int1 is int integral)
        {
            Console.WriteLine($"Original value: {integral}");
            Console.WriteLine($"Value x 2: {integral * 2}");
        }

        Console.WriteLine();
    }
}