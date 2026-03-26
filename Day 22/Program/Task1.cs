using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Rectangle
{ 
    public int Width { get; set; } 
    public int Height { get; set; }
    public int Area
    {
        get
        {
            return Width * Height;
        }
    }
}


class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");
        
        Rectangle rect1 = new Rectangle();
        rect1.Width = 10;
        rect1.Height = 10;
        Console.WriteLine($"The area of {rect1.Width} x {rect1.Height} is {rect1.Area}.");

        Console.WriteLine();
    }
}