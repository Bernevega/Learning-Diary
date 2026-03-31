using System;

class Order
{
    public string CustomerName { get; set; }
    public double Price { get; set; }
    public double DiscountPercent { get; set; }

    public void PrintFinalPrice()
    {
        if (!IsValid())
        {
            return;
        }

        double finalPrice = CalculateFinalPrice();
        PrintInfo(finalPrice);
    }

    private bool IsValid()
    {
        if (string.IsNullOrWhiteSpace(CustomerName))
        {
            Console.WriteLine("Customer name is missing");
            return false;
        }

        if (Price < 0)
        {
            Console.WriteLine("Price cannot be negative");
            return false;
        }

        if (DiscountPercent < 0 || DiscountPercent > 100)
        {
            Console.WriteLine("Discount must be between 0 and 100");
            return false;
        }

        return true;
    }

    private double CalculateFinalPrice()
    {
        double discountAmount = Price * DiscountPercent / 100.0;
        return Price - discountAmount;
    }

    private void PrintInfo(double finalPrice)
    {
        Console.WriteLine("Customer: " + CustomerName);
        Console.WriteLine("Original price: " + Price);
        Console.WriteLine("Discount: " + DiscountPercent + "%");
        Console.WriteLine("Final price: " + finalPrice);
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Order order1 = new Order();
        order1.CustomerName = "Alex";
        order1.Price = 1000;
        order1.DiscountPercent = 10;
        order1.PrintFinalPrice();

        Console.WriteLine();
    }
}