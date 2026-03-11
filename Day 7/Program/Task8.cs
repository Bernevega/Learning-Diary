using System;
class Task8
{
    public static void TaskEight()
    {
        int[] array = { 0, 543, 423, 146, -5435 };

        Console.WriteLine("Original array:");
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        Console.WriteLine("Sorted array:");
        Array.Sort(array);
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        Console.WriteLine("Reversed array:");
        Array.Reverse(array);
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
    }
}