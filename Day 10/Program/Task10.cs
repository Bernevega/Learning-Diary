using System;
class Task10
{
    public static void TaskTen()
    {
        string sentence = "I like cats";
        Console.WriteLine($"Your original sentence {sentence}");
        Console.WriteLine($"Your changed sentense: {sentence.Replace("cats", "dogs")}");

        Console.WriteLine();
    }
}