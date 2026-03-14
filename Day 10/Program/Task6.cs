using System;
class Task6
{
    public static void TaskSix()
    {
        Console.WriteLine("Write a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your original sentence: {sentence}");
        Console.WriteLine($"Uppercase version: {sentence.ToUpper()}");
        Console.WriteLine($"Lowercase version: {sentence.ToLower()}");

        Console.WriteLine();
    }
}