using System;
class Task13
{
    public static void TaskThirteen()
    {
        List<int> tasks = new List<int> { 1, 100, 53, 328, -43, 2, 1020 };

        int biggestNumber = tasks[0];
        foreach (int task in tasks)
        {
            if (task > biggestNumber)
                biggestNumber = task;
        }
        Console.WriteLine(biggestNumber);
        
        Console.WriteLine();
    }
}