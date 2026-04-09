using System;

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        IAnimal dog1 = new Dog();
        dog1.Speak();
        IAnimal cat1 = new Cat();
        cat1.Speak();

        Console.WriteLine();
    }
}