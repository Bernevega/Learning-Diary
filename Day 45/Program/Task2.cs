using System;

class Task2
{
    public static void PrintUser(string name, int age)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        string userName = "Mila";
        int userAge = 20;

        PrintUser(userName, userAge);

        Console.WriteLine("Done!");

        Console.WriteLine();
    }
}