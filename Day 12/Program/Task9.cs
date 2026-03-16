using System;
using System.Collections.Generic;

class Phone
{
    public string brand;
    public string model;
    public double price;
}
class Task9
{
    public static void TaskNine()
    {
        Phone phone1 = new Phone();
        Phone phone2 = new Phone();

        phone1.price = 25.50;
        phone2.price = 30.00;

        if (phone1.price > phone2.price)
            Console.WriteLine("Phone 1 is more expensive than Phone 2.");
        else if (phone1.price < phone2.price)
            Console.WriteLine("Phone 2 is more expensive than Phone 1.");
        else
            Console.WriteLine("Phone 1 and Phone 2 have the same price.");

        Console.WriteLine();
    }
}