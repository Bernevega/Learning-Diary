using System;
using System.Collections.Generic;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public Car(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Car car1 = new Car("Toyota", 2020);
        Car car2 = new Car("Honda", 2018);

        Console.WriteLine($"Car 1: {car1.Brand}, Year: {car1.Year}");
        Console.WriteLine($"Car 2: {car2.Brand}, Year: {car2.Year}");

        Console.WriteLine();
    }
}