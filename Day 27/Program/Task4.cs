using System;

class TemperatureLogger
{
    public double temp;
    public string dayTime;

    public void PrintTemperature()
    {
        if (!InputCheck())
        {
            return;
        }

        if (dayTime.ToUpper() == "MORNING")
            Console.WriteLine("Morning temperature: " + temp);
        else if (dayTime.ToUpper() == "AFTERNOON")
            Console.WriteLine("Afternoon temperature: " + temp);
        else if (dayTime.ToUpper() == "EVENING")
            Console.WriteLine("Evening temperature: " + temp);
    }

    private bool InputCheck()
    {
        if (dayTime == null || dayTime == "" ||
            (dayTime.ToUpper() != "MORNING" &&
             dayTime.ToUpper() != "AFTERNOON" &&
             dayTime.ToUpper() != "EVENING"))
        {
            Console.WriteLine("Invalid dayTime");
            return false;
        }

        if (temp < -50 || temp > 50)
        {
            Console.WriteLine("Invalid temperature");
            return false;
        }

        return true;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        TemperatureLogger log1 = new TemperatureLogger();
        Console.WriteLine("Please write the time of the day:");
        log1.dayTime = Console.ReadLine();
        Console.WriteLine("Please write the temperature:");
        log1.temp = double.Parse(Console.ReadLine());
        log1.PrintTemperature();

        Console.WriteLine();
    }
}