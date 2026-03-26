using System;
using System.Collections.Generic;

class Temperature
{
    public double Celsius { get; set; }

    public double Fahrenheit
    {
        get
        {
            return Celsius * 9 / 5 + 32;
        }
    }
}

class Task7
{
    public static void TaskSeven()
    {
        Console.WriteLine("--- Task 7 ---");

        Temperature temp1 = new Temperature();
        temp1.Celsius = 100;
        Console.WriteLine($"{temp1.Celsius} Celsius is {temp1.Fahrenheit} Fahrenheit.");
        Console.WriteLine();
    }
}