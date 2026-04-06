using System;

class Animal
{
    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating. So cute!");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Dog dog1 = new Dog();
        dog1.Name = "Kira";
        dog1.Eat();
        dog1.Bark();

        Console.WriteLine();
    }
}