using System;
class Task6
{
    public static void TaskSix()
    {
        int[,] numbers =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int biggestValue = numbers[0, 0];
        int smallestValue = numbers[0, 0];

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] < smallestValue)
                    smallestValue = numbers[i, j];
                if (numbers[i, j] > biggestValue)
                    biggestValue = numbers[i, j];
            }
        }

        Console.WriteLine($"The biggest array value: {biggestValue}");
        Console.WriteLine($"The smallest array value: {smallestValue}");

        Console.WriteLine();
    }
}