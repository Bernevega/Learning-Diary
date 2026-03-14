using System;
class Task7
{
    public static void TaskSeven()
    {
        Console.WriteLine("Write a sentence with spaces in the beginning and end:");
        string sentence = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your original sentence: {sentence}");
        Console.WriteLine($"Yours trimmed sentence: {sentence.Trim()}");
        Console.WriteLine($"Your original sentence's length: {sentence.Length}");
        Console.WriteLine($"Your trimmed sentence's length: {sentence.Trim().Length}");

        Console.WriteLine();
    }
}