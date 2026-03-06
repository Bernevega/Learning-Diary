using System;
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("Please write the number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        if (num % 2 == 0)
            Console.WriteLine("The number is even");
        else
            Console.WriteLine("The number is odd.");
        Console.WriteLine("");
    }
}