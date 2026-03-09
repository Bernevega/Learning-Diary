using System;
class Task3
{
    public static void TaskThree()
    {
        int[] numbers = { 1, 10, 100, 150, 10000 };
        numbers[3] = 1000;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
    }
}