using System;

class Task3
{
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        int first = 5;
        int second = 7;

        int result = AddNumbers(first, second);

        Console.WriteLine("Result: " + result);

        Console.WriteLine();
    }
}