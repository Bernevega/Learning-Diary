using System;
class Task3
{
    public static void TaskThree()
    {
        int[] numbers = { 5, 9, 2, 7, 1, 4 };
        Console.WriteLine($"The index of 7 is {Array.IndexOf(numbers, 7)}.");
        Console.WriteLine($"The index of 100 is {Array.IndexOf(numbers, 100)}.");

        Console.WriteLine();
    }
}