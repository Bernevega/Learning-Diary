using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Car
{
    public string Brand { get; set; } 
    public int Year { get; set; }
}


class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");
        
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Year = 2010;
        Console.WriteLine($"{car1.Brand}, {car1.Year}.");

        Console.WriteLine();
    }
}