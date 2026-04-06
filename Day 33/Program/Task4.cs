using System;

class Product
{
    public string Name { get; set; }
    public Product (string name)
    {
        if (name == null)
        {
            Console.WriteLine($"The name cannot be null!");
            Name = "Null";
        }
        else
            Name = name;
    }
}

class EBook : Product
{
    public double FileSize { get; set; }
    public EBook (string name, double fileSize) : base(name)
    {
        if (fileSize <= 0)
        {
            Console.WriteLine($"The file size cannot be 0 or less!");
            FileSize = 0;
        }
        else
            FileSize = fileSize;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"File size: {FileSize} MB");
    }
}
class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        EBook ebook = new EBook("C# Basics", 12.5);
        ebook.ShowInfo();

        Console.WriteLine();
    }
}