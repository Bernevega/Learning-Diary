using System;
class Task1
{
    public static void TaskOne()
    {
        int[,] array =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}