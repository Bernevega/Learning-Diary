using System;
class Task7
{
    public static void TaskSeven()
    {
        Console.WriteLine("Please write your number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (num >= 10 && num <= 20)
            Console.WriteLine("The number is inside the range 10 to 20.");
        else
            Console.WriteLine("The number is outside the range.");
        Console.WriteLine("");
    }
}