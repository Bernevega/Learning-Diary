using System;
class Task2
{
    public static void TaskTwo()
    {
        string[] movieNames = { "Star Wars", "Harry Potter", "Hobbit" };

        foreach (string movieName in movieNames)
        {
            Console.WriteLine(movieName);
        }

        Console.WriteLine();
    }
}