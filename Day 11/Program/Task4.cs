using System;
using System.Collections.Generic;

class Task4
{
    public static void TaskFour()
    {
        List<string> list = new List<string> { "One", "Two", "Three" };
        Console.WriteLine("Original list:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        Console.WriteLine();

        list[1] = "Four";
        Console.WriteLine("Changed list:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine();
    }
}