using System;
class Task10
{
    public static void TaskTen()
    {
        int[,] numbers =
        {
            { 5, 8, 2 },
            { 9, 1, 7 },
            { 2, 3, 4 }
        };

        int rowSum = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                rowSum += numbers[i, j];
            }
            Console.WriteLine($"Row {i} sum: {rowSum}");
            rowSum = 0;
        }

        Console.WriteLine();
    }
}