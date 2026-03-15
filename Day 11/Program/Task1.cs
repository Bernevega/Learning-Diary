using System;
using System.Collections.Generic;

class Task1
{
    public static void TaskOne()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }

        Console.WriteLine();
    }
}