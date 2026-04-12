using System;

class Task5
{
    public static void Point(int x, int y)
    {
        (int X, int Y) point = (x, y);

        string location = point switch
        {
            (0, 0) => "Origin",
            (_, 0) => "On X-axis",
            (0, _) => "On Y-axis",
            (> 0, > 0) => "Quadrant I",
            (< 0, > 0) => "Quadrant II",
            (< 0, < 0) => "Quadrant III",
            (> 0, < 0) => "Quadrant IV"
        };

        Console.WriteLine(location);
    }
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Point(0, 0);
        Point(4, 0);
        Point(0, -3);
        Point(2, 5);
        Point(-2, 7);
        Point(-1, -4);
        Point(3, -8);

        Console.WriteLine();
    }
}