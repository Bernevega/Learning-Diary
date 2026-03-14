using System;
class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("Write a word:");
        string word = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"The first character of your word is: {word[0]}");
        Console.WriteLine($"The last character of your word is: {word[word.Length - 1]}");

        Console.WriteLine();
    }
}