using System;
using System.Drawing;

abstract class Shape
{
    public abstract void GetArea();
}

class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void GetArea()
    {
        Console.WriteLine($"Area: {Width * Height}");
    }
}

class Circle : Shape
{
    public int Radius { get; set; }

    public override void GetArea()
    {
        Console.WriteLine($"Area: {Math.PI * Radius * Radius}");
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Rectangle rect1 = new Rectangle();
        rect1.Width = 10;
        rect1.Height = 35;

        Circle circle1 = new Circle();
        circle1.Radius = 5;

        Shape shape1 = rect1;
        Shape shape2 = circle1;

        shape1.GetArea();
        shape2.GetArea();

        Console.WriteLine();
    }
}