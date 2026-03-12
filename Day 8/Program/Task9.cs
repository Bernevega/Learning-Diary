using System;
class Task9
{
    public static void TaskNine()
    {
        int[,] numbers =
        {
            { 5, 8, 2 },
            { 9, 1, 7 },
            { 2, 3, 4 }
        };

        int evenNums = 0;
        int oddNums = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] % 2 == 0)
                    evenNums++;
                else
                    oddNums++;
            }
        }

        Console.WriteLine($"Even numbers: {evenNums}");
        Console.WriteLine($"Odd numbers: {oddNums}");

        Console.WriteLine();
    }
}