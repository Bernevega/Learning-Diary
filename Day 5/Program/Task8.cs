using System;
class Task8
{
    public static void TaskEight()
    {
        int[] numbers = { 1, 5, 9, 10, 17, 25, 30, 40 };
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Even numbers count: {count}");
        Console.WriteLine();
    }
}