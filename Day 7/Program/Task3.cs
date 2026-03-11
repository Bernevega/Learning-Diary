using System;
class Task3
{
    public static void TaskThree()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine(numbers[2]);
        Console.WriteLine();

        numbers[numbers.Length - 1] = 1;
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}