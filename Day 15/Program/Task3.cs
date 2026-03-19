using System;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public void StartEngine()
    {
        Console.WriteLine($"The {Brand} car from {Year} is starting.");
    }
}

class Task3
{
    public static void TaskThree()
    {
        Car car1 = new Car();
        Car car2 = new Car();
        car1.Brand = "Toyota";
        car1.Year = 2016;
        car2.Brand = "BMW";
        car2.Year = 2026;

        car1.StartEngine();
        car2.StartEngine();

        Console.WriteLine();
    }
}