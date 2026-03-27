using System;
using System.Collections.Generic;

class Phone
{
    public string Model { get; set; }
    public double Price { get; set; }

    public static void PrintInfo(Phone obj)
    {
        if (obj.Model == null)
            Console.WriteLine("The phone object does not exist yet.");
        else
            Console.WriteLine($"{obj.Model}, {obj.Price}€.");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("--- Task 5 ---");

        Phone phone1 = new Phone();
        phone1.Model = null;
        phone1.Price = 129.99;
        Phone.PrintInfo(phone1);

        phone1.Model = "Samsung";
        phone1.Price = 129.99;
        Phone.PrintInfo(phone1);

        Console.WriteLine();
    }
}