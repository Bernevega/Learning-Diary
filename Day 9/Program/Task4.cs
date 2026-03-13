using System;

class Task4
{
    public static void TaskFour()
    {
        int[] numbers = { 7, 2, 9, 1, 5, 3 };
        Console.WriteLine("Before sorting:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Array.Sort(numbers);
        Console.WriteLine("After sorting:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine();
    }
}