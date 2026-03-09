using System;
class Task5
{
    public static void TaskFive()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"The sum of this array is: {sum}");
        Console.WriteLine();
    }
}