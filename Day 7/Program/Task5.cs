using System;
class Task5
{
    public static void TaskFive()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Write a number: ");
            numbers[i] = int.Parse(Console.ReadLine()!);
        }

        int largest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (largest < numbers[i])
                largest = numbers[i];
        }
        Console.WriteLine($"The largest number is: {largest}");

        int smallest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (smallest > numbers[i])
                smallest = numbers[i];
        }
        Console.WriteLine($"The smallest number is: {smallest}");

        Console.WriteLine();
    }
}