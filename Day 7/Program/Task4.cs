using System;

class Task4
{
    public static void TaskFour()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Write a number: ");
            numbers[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine();
        Console.Write("Your numbers: ");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Sum: " + sum);

        Console.WriteLine();
    }
}