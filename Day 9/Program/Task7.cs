using System;
class Task7
{
    public static void TaskSeven()
    {
        int[] arr = new int[5];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Please write a number:");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Your original array:");
        foreach (int number in arr)
            Console.Write(number + " ");
        Console.WriteLine();
        Console.WriteLine();

        Array.Sort(arr);
        Console.WriteLine("Your sorted array:");
        foreach (int number in arr)
            Console.Write(number + " ");
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine($"Smallest value: {arr[0]}");
        Console.WriteLine($"Biggest value: {arr[arr.Length - 1]}");

        Console.WriteLine();
    }
}