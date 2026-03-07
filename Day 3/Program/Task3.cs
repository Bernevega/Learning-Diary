using System;
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("Please enter a number:");
        int amount = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine("Hello!");
        }
        Console.WriteLine("");
    }
}