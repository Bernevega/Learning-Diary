using System;
using System.Collections.Generic;

class Pet
{
    public string name;
    public string animalType;
    public int hungerLevel;

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Animal Type: {animalType}");
        Console.WriteLine($"Hunger Level: {hungerLevel}");
        Console.WriteLine();
    }

    public void Feed()
    {
        hungerLevel -= 1;
        Console.WriteLine($"{name} has been fed!");
        Console.WriteLine();
    }
}

class Task8
{
    public static void TaskEight()
    {
        Pet pet1 = new Pet();

        pet1.name = "Crit";
        pet1.animalType = "Cat";
        pet1.hungerLevel = 100;

        pet1.PrintInfo();
        pet1.Feed();
        pet1.PrintInfo();
    }
}