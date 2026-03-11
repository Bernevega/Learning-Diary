using System;
class Task7
{
    public static void TaskSeven()
    {
        string[] items = { "apple", "banana", "orange", "strawberry", "blueberry" };

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i}: {items[i]}");
        }
        Console.WriteLine();
    }
}