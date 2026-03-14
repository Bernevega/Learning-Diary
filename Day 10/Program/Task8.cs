using System;
class Task8
{
    public static void TaskEight()
    {
        Console.WriteLine("Write a sentence:");
        string sentence = Console.ReadLine();
        Console.WriteLine();

        if (sentence.Contains("C#"))
            Console.WriteLine("The sentence contains C#.");
        else
            Console.WriteLine("The sentence does not contain C#.");

        Console.WriteLine();
    }
}