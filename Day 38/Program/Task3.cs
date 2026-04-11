using System;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        object null1 = null;
        if (null1 is null)
            Console.WriteLine("No value found");
        else
            Console.WriteLine("Value exists");

            Console.WriteLine();
    }
}