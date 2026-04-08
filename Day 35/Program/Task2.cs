using System;

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Animal dog1 = new Dog();
        dog1.Name = "Kira";
        dog1.MakeSound();
        dog1.Sleep();

        Animal cat1 = new Cat();
        cat1.Name = "Crit";
        cat1.MakeSound();
        cat1.Sleep();

        Console.WriteLine();
    }
}