using System;
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your favorite food?");
        string favFood = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your name is {name}, you are {age} years old, and your favorite food is {favFood}.");

        Console.WriteLine();
    }
}