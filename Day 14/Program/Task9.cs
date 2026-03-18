using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    private int price;
    public int Price 
    { 
        get { return price; }
        set 
        {
            if (value >= 0)
                price = value;
            else
                price = 0;
        } 

    }
    
}
class Task9
{
    public static void TaskNine()
    {
        Product product1 = new Product();
        Console.WriteLine("Please write the product's name:");
        product1.Name = Console.ReadLine();
        Console.WriteLine("Please write the product's price:");
        product1.Price = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Product name: {product1.Name}. Its price: {product1.Price}");

        Console.WriteLine();
    }
}