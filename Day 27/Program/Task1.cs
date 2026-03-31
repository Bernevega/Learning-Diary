using System;

class CarExample
{
    public string Model;
    public int Fuel;
    public int Speed;
    public string DriverName;
    public int DriverAge;
    public string RadioSong;
    public int EngineTemperature;

    public void Drive()
    {
        Fuel--;
        Speed += 10;
        EngineTemperature += 5;
    }

    public void Brake()
    {
        Speed -= 10;
        if (Speed < 0)
        {
            Speed = 0;
        }
    }

    public void PlayRadio()
    {
        Console.WriteLine("Now playing: " + RadioSong);
    }

    public void PrintDriverInfo()
    {
        Console.WriteLine("Driver: " + DriverName + ", Age: " + DriverAge);
    }

    public void PrintCarInfo()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Fuel: " + Fuel);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Engine temperature: " + EngineTemperature);
    }
}

class Task1
{
    public static void TaskOne()
    {
        /*
        Look at the class and write in your own words why it is too large.
        Name at least 3 problems.

        There should be multiple classes instead. For example:
        -Car
            Model, Fuel, Speed, EngineTemperature
        -Driver
            DriverName, DriverAge
        -Radio
            RadioSong

        This class mixes car data and the driver data together.
        The class has low cohesion.
        Becomes harder to maintain later.

        */
    }
}