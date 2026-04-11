using System;

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        object value = "This object is a string";
        if (value is string text)
        {
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
        }

        Console.WriteLine();
    }
}