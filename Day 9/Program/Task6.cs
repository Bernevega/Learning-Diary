using System;
class Task6
{
    public static void TaskSix()
    {
        int[] numbers = { 4, 6, 9, 2, 8};
        Console.WriteLine("Original array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Array.Sort(numbers);
        Console.WriteLine("Sorted array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Smallest value: {numbers[0]}");
        Console.WriteLine($"Biggest value: {numbers[numbers.Length - 1]}");

        Console.WriteLine();
    }
}