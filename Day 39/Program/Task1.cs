using System;

class Task1
{
    public static void Score(int score)
    {
        if (score is < 0 or > 100)
            Console.WriteLine("Invalid score");
        else if (score is >= 0 and < 50)
            Console.WriteLine("Fail");
        else if (score is >= 50 and < 75)
            Console.WriteLine("Pass");
        else if (score is >= 75 and < 90)
            Console.WriteLine("Good");
        else
            Console.WriteLine("Excellent");
    }
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Score(-10);
        Score(30);
        Score(68);
        Score(85);
        Score(100);

        Console.WriteLine();
    }
}