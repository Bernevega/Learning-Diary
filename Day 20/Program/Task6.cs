using System;
using System.Collections.Generic;

class Lamp
{
    private bool isOn;
    public string Brand { get; set; }

    public void TurnOn()
    {
        isOn = true;
    }

    public void TurnOff()
    {
        isOn = false;
    }

    public void ShowState()
    {
        if (isOn)
        {
            Console.WriteLine("The lamp is on!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The lamp is off!");
            Console.WriteLine();
        }
    }
}

class Task6
{
    public static void TaskSix()
    {
        Console.WriteLine("--- Task 6 ---");
        Lamp lamp1 = new Lamp();
        lamp1.TurnOn();
        lamp1.ShowState();
        lamp1.TurnOff();
        lamp1.ShowState();
    }
}