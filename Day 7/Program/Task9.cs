using System;
class Task9
{
    public static void TaskNine()
    {
        int[] array = { 4, 53, 41, 14, -5 };

        Console.WriteLine("Write a number to search:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int found = Array.IndexOf(array, num);

        if (found == -1)
            Console.WriteLine("Number not found");
        else
            Console.WriteLine($"The number was found. Index: {found}");

        Console.WriteLine();
    }
}