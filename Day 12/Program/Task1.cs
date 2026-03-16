using System;
using System.Collections.Generic;

class Car
{
    public string brand;
    public string model;
    public int year;


    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine();
    }
}
class Task1
{
    public static void TaskOne()
    {
        Car car1 = new Car();
        car1.brand = "Land Rover";
        car1.model = "Discovery";
        car1.year = 2015;
        car1.PrintInfo();
    }
}