using System;
using System.Collections.Generic;

class Task2
{
    public static void TaskTwo()
    {
        List<string> list = new List<string> { "Ann", "Max", "Elna", "Veera" };
        
        Console.WriteLine($"First item: {list[0]}");
        Console.WriteLine($"Last item: {list[list.Count - 1]}");

        Console.WriteLine();
    }
}