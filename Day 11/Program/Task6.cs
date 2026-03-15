using System;
using System.Collections.Generic;

class Task6
{
    public static void TaskSix()
    {
        List<string> colors = new List<string> { "Blue", "Yellow", "Red", "Green" };

        Console.WriteLine("Original list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
        Console.WriteLine();

        colors.Remove("Red");
        Console.WriteLine("Edited list:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        Console.WriteLine();
    }
}