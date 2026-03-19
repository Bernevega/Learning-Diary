using System;
using System.Collections.Generic;

class Cat
{
    public string Name { get; set; }

    public Cat(string name)
    {
        Name = name;
    }

    public void Meow()
    {
        Console.WriteLine($"{Name} says meow!");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Cat cat1 = new Cat("Crit");
        cat1.Meow();

        Console.WriteLine();
    }
}