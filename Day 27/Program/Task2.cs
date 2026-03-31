using System;

class Car
{
    public string Model;
    public int Fuel;
    public int Speed;
    public int EngineTemperature;
    public Driver CarDriver;

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

    public void PrintCarInfo()
    {
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Fuel: " + Fuel);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Engine temperature: " + EngineTemperature);
    }
}

class Driver
{
    public string DriverName;
    public int DriverAge;

    public void PrintDriverInfo()
    {
        Console.WriteLine("Driver: " + DriverName + ", Age: " + DriverAge);
    }
}

class Radio
{
    public string RadioSong;
    public void PlayRadio()
    {
        Console.WriteLine("Now playing: " + RadioSong);
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Driver driver1 = new Driver();
        driver1.DriverAge = 25;
        driver1.DriverName = "Bob";

        Car car1 = new Car();
        car1.Model = "Toyota";
        car1.Fuel = 50;
        car1.Speed = 0;
        car1.EngineTemperature = 70;
        car1.CarDriver = driver1;

        car1.PrintCarInfo();
        car1.CarDriver.PrintDriverInfo();

        Console.WriteLine();
    }
}