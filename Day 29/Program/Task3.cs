using System;

struct Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            Console.WriteLine("Wrong dimensions!");
            Width = 1;
            Height = 1;
        }

        else
        {
            Width = width;
            Height = height;
        }
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Area: {GetArea()}");
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Rectangle rect1 = new Rectangle(4, 10);
        rect1.PrintInfo();

        Console.WriteLine();
    }
}