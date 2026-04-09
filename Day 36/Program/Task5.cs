using System;
interface IStartable
{
    public void Start();
}

interface IStoppable
{
    public void Stop();
}

class Machine : IStartable, IStoppable
{
    public void Start()
    {
        Console.WriteLine("Machine started");
    }

    public void Stop()
    {
        Console.WriteLine("Machine stopped");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Machine machine1 = new Machine();
        machine1.Start();
        machine1.Stop();

        Console.WriteLine();
    }
}