using System;
class Task12
{
    public static void TaskTwelve()
    {
        Console.WriteLine("Please write a word:");
        string word = Console.ReadLine();

        Console.WriteLine($"The word: {word}");
        Console.WriteLine($"Its length: {word.Length}");
        Console.WriteLine($"First character: {word[0]}");
        Console.WriteLine($"Last character: {word[word.Length - 1]}");
        Console.WriteLine($"Uppercase version: {word.ToUpper()}");
        Console.WriteLine($"Lowercase version: {word.ToLower()}");
    }
}