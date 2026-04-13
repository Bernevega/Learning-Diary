using System;

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");

        Console.WriteLine("Compile-time error example:");
        Console.WriteLine("A compile-time error is found before the program runs.");

        // Example of a compile-time error:
        // int number = "hello";

        Console.WriteLine();

        Console.WriteLine("Runtime error example:");
        Console.WriteLine("A runtime error happens while the program is running.");

        // Example of a runtime error:
        // int value = int.Parse("abc");

        Console.WriteLine();

        Console.WriteLine("Logic error example:");
        Console.WriteLine("A logic error means the program runs, but gives the wrong result.");

        int width = 5;
        int height = 10;
        int area = width + height; // Wrong on purpose, should be width * height

        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Wrong area result: {area}");
        Console.WriteLine("This is a logic error because area should be width * height.");

        Console.WriteLine();
    }
}