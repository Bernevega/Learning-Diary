using System;

class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle moves");
    }
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car moves");
    }
}
class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bicycle moves");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Vehicle vehicle1 = new Vehicle();
        vehicle1.Move();

        Vehicle car1 = new Car();
        car1.Move();

        Vehicle bicycle1 = new Bicycle();
        bicycle1.Move();

        Console.WriteLine();
    }
}