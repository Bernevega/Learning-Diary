using System;
class Task11
{
    public static void TaskEleven()
    {
        int[,] arr =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        for (int column = 0; column < arr.GetLength(1); column++)
        {
            int sum = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                sum += arr[row, column];
            }

            Console.WriteLine($"Column {column} sum: {sum}");
        }

        Console.WriteLine();
    }
}