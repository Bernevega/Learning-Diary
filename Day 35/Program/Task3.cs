using System;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.Name = "Buddy";
        animal2.Name = "Milo";

        animal1.MakeSound();
        animal2.MakeSound();

        Console.WriteLine();
    }
}