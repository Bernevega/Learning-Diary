using System;

record Product(string Name, decimal Price);

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Product product1 = new Product("TV", 1200);
        Product product2 = product1 with { Price = 1500 };

        Console.WriteLine(product1);
        Console.WriteLine(product2);

        // The product1 object stayed unchanged
        // The product2 object is a copy

        Console.WriteLine();
    }
}