using System;
class Task15
{
    public static void TaskFifteen()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please write a number:");
            list.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine();

        Console.WriteLine("Your list:");
        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
    }
}