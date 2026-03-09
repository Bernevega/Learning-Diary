using System;
class Task7
{
    public static void TaskSeven()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Please enter 5 numbers one by one.");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Your array is now:");

        for (int o = 0; o < numbers.Length; o++)
        {
            Console.Write(numbers[o] + " ");
        }

        Console.WriteLine();
    }
}