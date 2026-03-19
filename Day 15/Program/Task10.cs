using System;
using System.Collections.Generic;

class Timer
{
    public int Seconds { get; set; }

    public void AddSeconds(int amount)
    {
        Seconds += amount;
        Console.WriteLine($"The timer currently has {Seconds} seconds (+{amount} seconds).");
    }

}
class Task10
{
    public static void TaskTen()
    {
        Timer timer1 = new Timer();
        timer1.Seconds = 0;
        timer1.AddSeconds(10);
        timer1.AddSeconds(50);
        timer1.AddSeconds(5);

        Console.WriteLine();
    }
}