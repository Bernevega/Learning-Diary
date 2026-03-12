using System;
class Task3
{
    public static void TaskThree()
    {
        int[,] numbers = new int[2, 3];

        numbers[0, 0] = 10;
        numbers[0, 1] = 20;
        numbers[0, 2] = 30;
        numbers[1, 0] = 40;
        numbers[1, 1] = 50;
        numbers[1, 2] = 60;

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