using System;

class Temperature
{
    private double celcius;

    public void SetTemperature(double temp)
    {
        if (temp >= -100 && temp <= 100) 
            celcius = temp;
    }

    public void ShowTemperature()
    {
        Console.WriteLine($"The temperature is: {celcius}");
        Console.WriteLine();
    }

}

class Task3
{
    public static void TaskThree()
    {
        Temperature temp = new Temperature();
        temp.SetTemperature(25);
        temp.ShowTemperature();
        temp.SetTemperature(-10000);
        temp.ShowTemperature();

        Console.WriteLine();
    }
}