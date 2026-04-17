using System;

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        int sum = 0;

        for (int i = 1; i <= 5; i++)
        {
            sum += i;
            Console.WriteLine($"i = {i}, sum = {sum}");
        }

        Console.WriteLine($"Final sum: {sum}");
        Console.WriteLine();
    }
}