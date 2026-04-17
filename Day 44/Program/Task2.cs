using System;

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        int price = 15;
        int quantity = 3;
        int total = price * quantity;
        int discount = 10;
        int finalPrice = total - discount;

        Console.WriteLine($"Final price: {finalPrice}");
        Console.WriteLine();
    }
}