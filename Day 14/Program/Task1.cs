using System;
using System.Collections.Generic;

class Dog
{
    public string Name { get; set; }
}

class Task1
{
    public static void TaskOne()
    {
        Dog dog1 = new Dog();
        dog1.Name = "Kira";

        Console.WriteLine($"The dog's name is: {dog1.Name}");
        Console.WriteLine();
    }
}