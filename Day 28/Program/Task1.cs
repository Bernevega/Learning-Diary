using System;

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Season season1 = Season.Summer;
        Console.WriteLine(season1);

        Console.WriteLine();
    }
}