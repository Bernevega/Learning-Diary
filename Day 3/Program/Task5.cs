using System;
class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("Please enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        int result = 1;

        for (int i = 1; i <= 10; i++)
        {
            result = number * i;
            Console.WriteLine($"{number} x {i} = {result}");
        }
        Console.WriteLine("");
    }
}