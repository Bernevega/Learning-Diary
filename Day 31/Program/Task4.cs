using System;

struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Point point1 = new Point(3, 5);
        Point point2 = new Point(3, 5);
        Point point3 = new Point(7, 2);

        Console.WriteLine($"Point 1 equals to point 2: {point1.Equals(point2)}");
        Console.WriteLine($"Point 1 equals to point 3: {point1.Equals(point3)}");

        Console.WriteLine();
    }
}