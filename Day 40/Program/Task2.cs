using System;
class Task2
{
    public static void NumberChecker(string input)
    {
        bool success = int.TryParse(input, out int number);
        if (success)
            Console.WriteLine("Valid number: " + number);
        else
            Console.WriteLine("Not an integer!");
    }
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        NumberChecker("156");
        NumberChecker("abc");
        NumberChecker("10,5");

        Console.WriteLine("");
    }
}