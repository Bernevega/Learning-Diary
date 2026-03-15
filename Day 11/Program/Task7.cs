using System;
using System.Collections.Generic;

class Task7
{
    public static void TaskSeven()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };

        list.RemoveAt(0);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
    }
}