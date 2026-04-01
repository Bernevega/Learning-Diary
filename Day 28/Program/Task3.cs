using System;

enum DayType
{
    Weekday,
    Weekend
}

class Day
{
    public static void CheckDay(DayType day)
    {
        switch (day)
        {
            case DayType.Weekday:
                Console.WriteLine("Time for work or study.");
                break;
            case DayType.Weekend:
                Console.WriteLine("Time to rest.");
                break;
        }
    }
}
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        DayType day1 = DayType.Weekday;
        Day.CheckDay(day1);

        Console.WriteLine();
    }
}