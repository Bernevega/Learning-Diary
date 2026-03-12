using System;
class Task7
{
    public static void TaskSeven()
    {
        int[,] arr =
        {
            { 5, 10, 15 },
            { 20, 25, 25 }
        };

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"[{i}, {j}] = {arr[i, j]}");
            }
        }

        Console.WriteLine();
    }
}