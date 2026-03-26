using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }

    public double FinalPrice
    {
        get
        {
            if (Discount < 0 || Discount > 100)
                return -1;

            return Price - (Price * Discount / 100);
        }
    }
}

class Task6
{
    public static void TaskSix()
    {
        Console.WriteLine("--- Task 6 ---");

        Product prod1 = new Product();
        prod1.Name = "Apple";
        prod1.Price = 0.5;
        prod1.Discount = 50;
        Console.WriteLine($"The final price of {prod1.Price}€ {prod1.Name} with a {prod1.Discount}% discount is {prod1.FinalPrice}€.");
        Console.WriteLine();

        Product prod2 = new Product();
        prod2.Name = "Banana";
        prod2.Price = 0.3;
        prod2.Discount = 10;
        Console.WriteLine($"The final price of {prod2.Price}€ {prod2.Name} with a {prod2.Discount}% discount is {prod2.FinalPrice}€.");
        Console.WriteLine();

        Product prod3 = new Product();
        prod3.Name = "Strawberry";
        prod3.Price = 1;
        prod3.Discount = 0;
        Console.WriteLine($"The final price of {prod3.Price}€ {prod3.Name} with a {prod3.Discount}% discount is {prod3.FinalPrice}€.");
        Console.WriteLine();

        Product prod4 = new Product();
        prod4.Name = "Kiwi";
        prod4.Price = 0.7;
        prod4.Discount = 100;
        Console.WriteLine($"The final price of {prod4.Price}€ {prod4.Name} with a {prod4.Discount}% discount is {prod4.FinalPrice}€.");
        Console.WriteLine();
    }
}