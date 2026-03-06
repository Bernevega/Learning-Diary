using System;
class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("Please write your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (age < 13)
            Console.WriteLine("You are a child.");
        else if (age >= 13 && age <= 17)
            Console.WriteLine("You are a teenager.");
        else
            Console.WriteLine("You are an adult.");
        Console.WriteLine("");
    }
}