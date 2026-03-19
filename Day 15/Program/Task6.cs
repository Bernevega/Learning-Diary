using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Lamp
{
    public bool IsOn { get; set; }
    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"The lamp is on: {IsOn}");
    }
    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"The lamp is on: {IsOn}");
    }
}
class Task6
{
    public static void TaskSix()
    {
        Lamp lamp1 = new Lamp();
        lamp1.TurnOn();
        lamp1.TurnOff();
        lamp1.TurnOn();
        lamp1.TurnOff();

        Console.WriteLine();
    }
}