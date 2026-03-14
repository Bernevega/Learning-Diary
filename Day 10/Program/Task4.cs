using System;

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("Write a word:");
        string word = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your word is: {word}");
        Console.WriteLine($"{word} contains {word.Length} symbols.");

        Console.WriteLine();
    }
}