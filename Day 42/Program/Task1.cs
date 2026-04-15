using System;

class Task1
{
    public static void CheckTemperature(int temperature)
    {
        if (temperature < -50 || temperature > 50)
            throw new ArgumentOutOfRangeException(nameof(temperature), "Temperature is invalid");
        else
            Console.WriteLine("Temperature is valid");
    }
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");

        try
        {
            CheckTemperature(25);
            CheckTemperature(100);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
    }
}