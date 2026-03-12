using System;

class Task4
{
    public static void TaskFour()
    {
        int[,] numbers = new int[2, 2];

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.WriteLine($"Please write a number for column {i}:");
                numbers[i, j] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        Console.WriteLine("Here is your array:");
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}