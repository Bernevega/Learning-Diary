using System;

class Task5
{
    public static void PrintTextLength(string text)
    {
        if (text == null)
        {
            Console.WriteLine("Text is null");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Text length:");
            Console.WriteLine(text.Length);
            Console.WriteLine();
        }
    }

    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        PrintTextLength(" ");
        PrintTextLength(null);
        PrintTextLength("hello");
        PrintTextLength("5");

        Console.WriteLine();
    }
}