using System;

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        string text1 = "hello";
        string text2 = "hello";
        string text3 = "world";

        Console.WriteLine($"Texts 1 and 2 are equal (==): {text1 == text2}");
        Console.WriteLine($"Texts 2 and 3 are equal (==): {text2 == text3}");
        Console.WriteLine($"Texts 1 and 3 are equal (==): {text1 == text3}");

        Console.WriteLine($"Texts 1 and 2 are equal (Equals()): {text1.Equals(text2)}");
        Console.WriteLine($"Texts 2 and 3 are equal (Equals()): {text2.Equals(text3)}");
        Console.WriteLine($"Texts 1 and 3 are equal (Equals()): {text1.Equals(text3)}");

        Console.WriteLine();
    }
}