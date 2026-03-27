using System;
using System.Collections.Generic;

class Laptop
{
    public string Brand { get; set; }
    public int Ram { get; set; }

    public static void PrintInfo(Laptop laptop)
    {
        {
            if (laptop == null)
                Console.WriteLine("The laptop object does not exist yet.");
            else if (laptop.Brand == null) 
                Console.WriteLine("The laptop name does not exist yet.");
            else
                Console.WriteLine($"{laptop.Brand}, {laptop.Ram}GB.");
        }
    }
}

class Task7
{
    public static void TaskSeven()
    {
        Console.WriteLine("--- Task 7 ---");

        Laptop laptop1 = new Laptop();
        laptop1.Brand = "Lenovo";
        laptop1.Ram = 4;
        Laptop.PrintInfo(laptop1);

        laptop1.Brand = null;
        Laptop.PrintInfo(laptop1);

        Console.WriteLine();
    }
}