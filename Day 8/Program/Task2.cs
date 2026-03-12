using System;

class Task2
{
    public static void TaskTwo()
    {
        int[,] array =
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int rowLength = array.GetLength(0);
        int colLength = array.GetLength(1);

        int rowIndex = array.GetLength(0) / 2;
        int columnIndex = array.GetLength(1) / 2;

        Console.WriteLine($"First array value: {array[0, 0]}");
        Console.WriteLine($"Last array value: {array[rowLength - 1, colLength - 1]}");
        Console.WriteLine($"Middle array value: {array[rowIndex, columnIndex]}");

        Console.WriteLine();
    }
}