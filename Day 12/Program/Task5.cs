using System;
using System.Collections.Generic;


class Dog
{
    public string name;
    public string breed;
    public int age;

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Breed: {breed}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine();
    }

    public void Bark()
    {
        Console.WriteLine($"{name} says: Woof!");
        Console.WriteLine();
    }
}

class Task5
{
    public static void TaskFive()
    {
        Dog dog1 = new Dog();
        dog1.name = "Buddy";
        dog1.breed = "Golden Retriever";
        dog1.age = 3;

        dog1.PrintInfo();
        dog1.Bark();
    }
}