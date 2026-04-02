using System;

struct Point
{
    public int X;
    public int Y;
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Point point1;
        point1.X = 10;
        point1.Y = 25;
        Console.WriteLine($"{point1.X}, {point1.Y}");

        Console.WriteLine();
    }
}