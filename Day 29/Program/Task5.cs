using System;

struct Temperature
{
    public double Celsius { get; set; }

    public Temperature(double celsius)
    {
        if (celsius < -250 || celsius > 250)
        {
            Console.WriteLine("Wrong temperature!");
            Celsius = 0;
        }
        else
            Celsius = celsius;
    }

    public double ToFahrenheit()
    {
        return (Celsius * 9 / 5) + 32;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Celsius}°C is {ToFahrenheit()}°F");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Temperature temp1 = new Temperature(100);
        temp1.Celsius = 100;
        temp1.PrintInfo();

        Console.WriteLine();
    }
}