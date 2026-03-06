using System;
class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("Please write your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (age < 12 || age >= 65)
            Console.WriteLine("Discount applies.");
        else
            Console.WriteLine("No discount.");
        Console.WriteLine("");
    }
}