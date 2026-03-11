using System;
using System.Xml.Linq;
class Task11
{
    public static void TaskEleven()
    {
        string[] names = { "Bob", "Alex", "Anna", "Elsa", "Matti" };

        Console.WriteLine("Original array:");
        foreach (string name in names)
        {
            Console.WriteLine(name + " ");
        }
        Console.WriteLine();

        Array.Sort(names);
        Console.WriteLine("Sorted array:");
        foreach (string name in names)
        {
            Console.WriteLine(name + " ");
        }
        Console.WriteLine();

        Array.Reverse(names);
        Console.WriteLine("Reversed array:");
        foreach (string name in names)
        {
            Console.WriteLine(name + " ");
        }
        Console.WriteLine();
    }
}