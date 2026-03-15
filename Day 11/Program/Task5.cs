using System;
using System.Collections.Generic;

class Task5
{
    public static void TaskFive()
    {
        List<string> list = new List<string> { "Bed", "Apple", "Cat", "Dog" };
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine($"Amount of items: {list.Count}");

        Console.WriteLine();
    }
}