using System;
using System.Collections.Generic;
class Task11
{
    public static void TaskEleven()
    {
        List<int> list = new List<int> { 0, 5, 10, 15, 20, 25, 30 };

        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        Console.WriteLine($"The sum of the list is: {sum}");

        Console.WriteLine();
    }
}