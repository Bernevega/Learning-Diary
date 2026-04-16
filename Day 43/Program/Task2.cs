using System;
class Product
{
    public string Name { get; set; }
    public decimal Price { get; private set; }

    public void SetPrice(decimal price)
    {
        if (price < 0)
        {
            Console.WriteLine("Price cannot be below 0.");
            return;
        }

        Price = price;
        Console.WriteLine($"Price set to {Price}");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Product product = new Product();
        product.Name = "Notebook";

        product.SetPrice(15.99m);
        Console.WriteLine($"Current price: {product.Price}");

        product.SetPrice(-5m);
        Console.WriteLine($"Current price: {product.Price}");

        product.SetPrice(25m);
        Console.WriteLine($"Current price: {product.Price}");

        Console.WriteLine();
    }
}