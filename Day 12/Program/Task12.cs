using System;

class Rectangle
{
    public double width;
    public double height;

    public void PrintInfo()
    {
        Console.WriteLine($"Width: {width}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine();
    }

    public double GetArea()
    {
        double area = width * height;
        return area;
    }
}

class Task12
{
    public static void TaskTwelve()
    {
        Rectangle rectangle1 = new Rectangle();
        rectangle1.width = 5;
        rectangle1.height = 10;

        rectangle1.PrintInfo();
        Console.WriteLine($"Area: {rectangle1.GetArea()}");
    }
}