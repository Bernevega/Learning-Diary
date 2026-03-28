using System;
using System.Collections.Generic;

class Battery
{
    public int Capacity{ get; set; }
    public int Percentage { get; set; }
}

class Phone
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public Battery PhoneBattery { get; set; }

    public void PrintInfo()
    {
        if (Model == null)
            Console.WriteLine("The model does not exist yet");
        else if (Brand == null)
            Console.WriteLine("The brand does not exist yet");
        else if (PhoneBattery == null)
            Console.WriteLine("The phone battery does not exist yet");
        else if (PhoneBattery.Capacity <= 0)
            Console.WriteLine("The phone capacity cannot be 0 or less");
        else if (PhoneBattery.Percentage < 0 || PhoneBattery.Percentage > 100)
            Console.WriteLine("The phone percentage cannot be less than 0 or more than 100");
        else
            Console.WriteLine($"{Brand} {Model} has capacity of {PhoneBattery.Capacity} and {PhoneBattery.Percentage}%.");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");

        Phone phone1 = new Phone();
        phone1.Model = "OnePlus 12";
        phone1.Brand = "OnePlus";

        phone1.PhoneBattery = new Battery();
        phone1.PhoneBattery.Capacity = 100;
        phone1.PhoneBattery.Percentage = 50;

        phone1.PrintInfo();

        Console.WriteLine();
    }
}