using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine($"Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Animal dog1 = new Dog();
        Animal animal1 = new Animal();

        animal1.MakeSound();
        dog1.MakeSound();

        Console.WriteLine();
    }
}