using System;
using System.Collections.Generic;
class Task9
{
    public static void TaskNine()
    {
        List<string> items = new List<string> { "Sword", "Stick", "Armor", "Gold" };
        items.Insert(items.Count / 2, "Potion");

        foreach (string item in items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}