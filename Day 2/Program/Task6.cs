using System;
class Task6
{
    public static void TaskSix()
    {
        Console.WriteLine("Please write your score from 0 to 100:");
        int score = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (score < 0 || score > 100)
            Console.WriteLine("Wrong score.");
        else if (score >= 0 && score <= 49)
            Console.WriteLine("Fail.");
        else if (score >= 50 && score <= 69)
            Console.WriteLine("Pass.");
        else if (score >= 70 && score <= 89)
            Console.WriteLine("Good.");
        else
            Console.WriteLine("Excellent.");
        Console.WriteLine("");
    }
}