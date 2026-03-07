using System;
class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("How many stars?");
        int amount = int.Parse((Console.ReadLine()));
        Console.WriteLine("");

        for (int i = 0; i < amount; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}