using System;
using System.Collections.Generic;

class Temperature
{
    private int celsius;
    public int Celsius
    {
        get { return celsius; }
        set
        {
            if (value >= -273)
                celsius = value;
        }
    }
}

class Task8
{
    public static void TaskEight()
    {
        Temperature temp1 = new Temperature();
        temp1.Celsius = 25;
        Console.WriteLine($"Temperature 1: {temp1.Celsius}");

        Temperature temp2 = new Temperature();
        temp2.Celsius = -1000;
        Console.WriteLine($"Temperature 2: {temp2.Celsius}");

        Console.WriteLine();
    }
}