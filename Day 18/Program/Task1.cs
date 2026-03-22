using System;
using System.Collections.Generic;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking!");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($"{Name} is meowing!");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Dog dog1 = new Dog();
        dog1.Name = "Kira";
        dog1.Age = 2;
        dog1.ShowInfo();
        dog1.Bark();
        Console.WriteLine();

        Cat cat1 = new Cat();
        cat1.Name = "Crit";
        cat1.Age = 4;
        cat1.ShowInfo();
        cat1.Meow();
        Console.WriteLine();
    }
}