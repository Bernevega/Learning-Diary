using System;
class Task5
{
    public static void TaskFive()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Before reverse:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Array.Reverse(numbers);
        Console.WriteLine("After reverse:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine();
    }
}