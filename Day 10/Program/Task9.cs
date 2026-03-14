using System;
class Task9
{
    public static void TaskNine()
    {
        Console.WriteLine("Write a word:");
        string sentence = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine($"Your sentence starts with \"A\": {sentence.StartsWith("A")}");
        Console.WriteLine($"Your sentence ends with \"n\": {sentence.EndsWith("n")}");

        Console.WriteLine();
    }
}