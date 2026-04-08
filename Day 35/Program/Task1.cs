using System;

abstract class Animal
{
    public string Name { get; set; }
    public abstract void MakeSound();
    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Animal dog1 = new Dog();
        dog1.Name = "Goldie";
        dog1.MakeSound();

        Console.WriteLine();
    }
}