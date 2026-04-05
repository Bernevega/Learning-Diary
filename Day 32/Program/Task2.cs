using System;

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
}
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Car car1 = new Car();
        Car car2 = new Car();

        car1.Brand = "Audi";
        car1.Year = 1997;

        car2.Brand = "Audi";
        car2.Year = 1997;

        Console.WriteLine($"Car1 and Car2 are the same: {car1.Equals(car2)}");
        // Because they are pointing to different objects.

        Console.WriteLine();
    }
}