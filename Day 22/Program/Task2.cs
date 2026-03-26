using System;
using System.Collections.Generic;

class Rectangle2
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Perimeter
    {
        get
        {
            return (Width + Height) * 2;
        }
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");

        Rectangle2 rect2 = new Rectangle2();
        rect2.Width = 10;
        rect2.Height = 10;
        Console.WriteLine($"The perimeter of {rect2.Width} x {rect2.Height} is {rect2.Perimeter}.");

        Console.WriteLine();
    }
}