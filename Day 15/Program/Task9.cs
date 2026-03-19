using System;
using System.Collections.Generic;

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void ShowArea()
    {
        Console.WriteLine($"The area of {Width} by {Height} is {Width * Height}.");
    }
}
class Task9
{
    public static void TaskNine()
    {
        Rectangle rectangle1 = new Rectangle();
        rectangle1.Width = 10;
        rectangle1.Height = 5;
        rectangle1.ShowArea();

        Console.WriteLine();
    }
}