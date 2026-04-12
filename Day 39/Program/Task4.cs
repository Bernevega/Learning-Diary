using System;

class Customer
{
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}

class Order
{
    public Customer Customer { get; set; }
    public int TotalAmount { get; set; }

    public static void CheckOrder(Order order)
    {
        if (order is { Customer: { IsPremium: true }, TotalAmount: >= 200 })
        {
            Console.WriteLine("Premium big order");
            Console.WriteLine();
        }
        else if (order is { Customer: { IsPremium: true }, TotalAmount: < 200 })
        {
            Console.WriteLine("Premium small order");
            Console.WriteLine();
        }
        else if (order is { Customer: { IsPremium: false }, TotalAmount: >= 200 })
        {
            Console.WriteLine("Regular big order");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Regular small order");
            Console.WriteLine();
        }
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Customer customer1 = new Customer { Name = "Anna", IsPremium = true };
        Customer customer2 = new Customer { Name = "Mira", IsPremium = true };
        Customer customer3 = new Customer { Name = "Bob", IsPremium = false };
        Customer customer4 = new Customer { Name = "Alex", IsPremium = false };

        Order order1 = new Order { Customer = customer1, TotalAmount = 250 };
        Order order2 = new Order { Customer = customer2, TotalAmount = 120 };
        Order order3 = new Order { Customer = customer3, TotalAmount = 100 };
        Order order4 = new Order { Customer = customer4, TotalAmount = 500 };

        Order.CheckOrder(order1);
        Order.CheckOrder(order2);
        Order.CheckOrder(order3);
        Order.CheckOrder(order4);

        Console.WriteLine();
    }
}