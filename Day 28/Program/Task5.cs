using System;

enum OrderStatus
{
    Pending,
    Preparing,
    Delivered
}

class Order
{
    private string status;

    public static void PrintStatus(OrderStatus status)
    {
        if (status == OrderStatus.Pending)
            Console.WriteLine("Your order was received.");
        else if (status == OrderStatus.Preparing)
            Console.WriteLine("Your food is being prepared.");
        else
            Console.WriteLine("Your order has arrived.");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        OrderStatus status = OrderStatus.Pending;
        Order.PrintStatus(status);
        status = OrderStatus.Preparing;
        Order.PrintStatus(status);
        status = OrderStatus.Delivered;
        Order.PrintStatus(status);

        Console.WriteLine();
    }
}