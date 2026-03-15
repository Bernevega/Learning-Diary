using System;
class Task14
{
    public static void TaskFourteen()
    {
        List<string> tasks = new List<string> { "Hello", "Hello", "Goodbye", "How are you?", "Hello" };

        int count = 0;
        foreach (string task in tasks)
        {
            if (task == "Hello")
                count++;
        }

        Console.WriteLine($"The word \"Hello\" appears {count} times.");
        
        Console.WriteLine();
    }
}