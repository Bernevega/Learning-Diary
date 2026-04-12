using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public bool InStock { get; set; }

    public static void CheckProduct(Product product)
    {
        if (product is { Price: >= 100, InStock: true })
        {
            Console.WriteLine("Premium product in stock");
            Console.WriteLine();
        }
        else if (product is { Price: < 20, InStock: true })
        {
            Console.WriteLine("Cheap product in stock");
            Console.WriteLine();
        }
        else if (product is { InStock: false })
        {
            Console.WriteLine("Out of stock");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Regular product");
            Console.WriteLine();
        }
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Product product1 = new Product { Name = "TV", Price = 1000, InStock = true };
        Product product2 = new Product { Name = "Dishwasher", Price = 2500, InStock = false };
        Product product3 = new Product { Name = "Charger", Price = 15, InStock = true };
        Product product4 = new Product { Name = "Speakers", Price = 80, InStock = true };

        Product.CheckProduct(product1);
        Product.CheckProduct(product2);
        Product.CheckProduct(product3);
        Product.CheckProduct(product4);
    }
}