using System;

record PersonRecord(string Name, int Age);
record struct Point(int X, int Y);

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        PersonRecord per1 = new PersonRecord("Bob", 65);
        Point point1 = new Point(10, 6);
        point1.X = 6;

        Console.WriteLine(per1);
        Console.WriteLine(point1);

        // Record PersonRecord is a reference type
        // Record struct Point is a value type
        // By default it's easier to use a record as immutable data

        Console.WriteLine();
    }
}