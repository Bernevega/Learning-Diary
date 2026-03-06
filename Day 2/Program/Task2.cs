using System;
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("Please write the number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (num < 0)
            Console.WriteLine("The number is negative.");
        else if (num > 0)
            Console.WriteLine("The number is positive.");
        else
            Console.WriteLine("The number is zero.");
        Console.WriteLine("");
    }
}