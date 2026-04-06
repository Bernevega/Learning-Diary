using System;

class Vehicle
{
    public string Brand { get; set; }
    public void Move()
    {
        Console.WriteLine($"{Brand} car is moving");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public void ShowCarInfo()
    {
        Console.WriteLine($"{Brand} has {NumberOfDoors} doors");
    }
}
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Car car1 = new Car();
        Car car2 = new Car();

        car1.Brand = "Audi";
        car1.NumberOfDoors = 4;
        car1.Move();
        car1.ShowCarInfo();

        Console.WriteLine();
    }
}