using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; set; }
    public int Value { get; set; }

    public static void IsEqual(Item item1, Item item2)
    {
        if (item1 == item2)
            Console.WriteLine($"Items {item1} and {item2} are equal");
        else
            Console.WriteLine($"Items {item1} and {item2} are not equal");
    }

    public static void PrintInfo(Item item)
    {
        {
            if (item == null)
                Console.WriteLine("The item object does not exist yet.");
            else if (item.Name == null)
                Console.WriteLine("The item name does not exist yet.");
            else
                Console.WriteLine($"{item.Name}, {item.Value}.");
        }
    }
}

class Task9
{
    public static void TaskNine()
    {
        Console.WriteLine("--- Task 9 ---");

        Item item1 = new Item();
        item1.Name = "Banana";
        item1.Value = 1;

        Item item2 = item1;

        Item item3 = new Item();
        item3.Name = "Apple";
        item3.Value = 2;

        Item.IsEqual(item1, item2);
        Item.IsEqual(item1, item3);

        item2.Name = "Kiwi";
        Console.WriteLine(item1.Name);

        Item item4 = null;
        Item.PrintInfo(item4);

        Console.WriteLine();
    }
}