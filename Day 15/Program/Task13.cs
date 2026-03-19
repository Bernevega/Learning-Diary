using System;
using System.Collections.Generic;

class TemperatureConverter
{
    public static void CelsiusToFahrenheit(double celsius)
    {
        Console.WriteLine($"{celsius} Degree Celsius is {(celsius * 9 / 5) + 32} Fahrenheit.");
    }

}
class Task13
{
    public static void TaskThirteen()
    {
        TemperatureConverter.CelsiusToFahrenheit(10);
        TemperatureConverter.CelsiusToFahrenheit(20.3);

        Console.WriteLine();
    }
}