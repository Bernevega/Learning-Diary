using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Product name: {Name}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Stock: {Stock}");
        Console.WriteLine();
    }

    public Product(string name, double price, int stock)
    {
        Name = name;

        if (price < 0)
            Price = 0;
        else
            Price = price;

        if (stock < 0)
            Stock = 0;
        else
            Stock = stock;
    }

    public void AddStock(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Your cannot add 0 or less");
            Console.WriteLine();
        }
        else
        {
            Stock += amount;
            Console.WriteLine($"{amount} of {Name} was added");
            Console.WriteLine();

        }
    }

    public void Sell(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"Your cannot sell 0 or less");
            Console.WriteLine();
        }
        else if (amount > Stock)
        {
            Console.WriteLine($"Cannot sell more than in stock");
            Console.WriteLine();
        }
        else
        {
            Stock -= amount;
            Console.WriteLine($"{amount} of {Name} was sold");
            Console.WriteLine();
        }
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("--- Task 4 ---");

        Product prod1 = new Product("TV", 1000, 10);

        prod1.AddStock(1);
        prod1.Sell(-10);
        prod1.Sell(10);
        prod1.Sell(2);
    }
}