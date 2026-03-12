using System;
using System.Xml.Linq;
class Task12
{
    public static void TaskTwelve()
    {
        int[,] numbers =
        {
            { 5, 8, 2 },
            { 9, 1, 7 },
            { 2, 3, 4 }
        };

        int biggestValue = numbers[0, 0];
        int row = 0;
        int col = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] > biggestValue)
                {
                    biggestValue = numbers[i, j];
                    row = i;
                    col = j;
                }
            }
        }

        Console.WriteLine($"Biggest value: {biggestValue}");
        Console.WriteLine($"Row: {row}");
        Console.WriteLine($"Column: {col}");
    }
}