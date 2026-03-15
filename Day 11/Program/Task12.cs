using System;
class Task12
{
    public static void TaskTwelve()
    {
        List<string> tasks = new List<string>();

        tasks.Add("Ann");
        tasks.Add("Henna");
        tasks.Add("Hilla");

        Console.WriteLine("The original list:");
        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine();

        tasks.Remove("Hilla");
        tasks.Add("Veera");
        Console.WriteLine("The edited list:");
        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
        Console.WriteLine();

        Console.WriteLine($"The final count: {tasks.Count}");

        Console.WriteLine();
    }
}