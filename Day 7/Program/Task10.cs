using System;
class Task10
{
    public static void TaskTen()
    {
        int[] array = { 1, 4, 2, 5, 8 };

        Console.WriteLine("The original array:");
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        Array.Clear(array, 0, 3);

        // Removed values 1, 4 and 2
        Console.WriteLine("The modified array:");
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}