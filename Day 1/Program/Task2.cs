using System;

class Task2
{
    public static void TaskTwo()
    {
        string name = "Ann";
        int age = 21;
        float heightMeters = 1.55f;
        bool likesCSharp = true;

        // With $ format:
        Console.WriteLine("TASK 2 - 1");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {heightMeters}");
        Console.WriteLine($"Likes C#: {likesCSharp}");
        Console.WriteLine("");

        // With + format:
        Console.WriteLine("TASK 2 - 2");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + heightMeters);
        Console.WriteLine("Likes C#: " + likesCSharp);
        Console.WriteLine("");
    }
}