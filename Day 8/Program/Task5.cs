using System;
class Task5
{
    public static void TaskFive()
    {
        int[,] numbers =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int sum = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                sum += numbers[i, j];
            }
        }
        Console.WriteLine($"The sum of the array is: {sum}");

        Console.WriteLine();
    }
}