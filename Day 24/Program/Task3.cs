using System;
using System.Collections.Generic;

class Pet
{
    public string Name { get; set; }
    public string AnimalType { get; set; }
}

class Owner
{
    public string Name { get; set; }
    public Pet MyPet{ get; set; }

    public void PrintInfo()
    {
        if (Name == null)
            Console.WriteLine("The owner name does not exist yet");
        else if (MyPet == null)
            Console.WriteLine("The pet does not exist yet");
        else if (MyPet.Name == null)
            Console.WriteLine("The pet name does not exist yet");
        else if (MyPet.AnimalType == null)
            Console.WriteLine("The pet animal type does not exist yet");
        else
            Console.WriteLine($"{Name} owns a {MyPet.AnimalType} called {MyPet.Name}.");
    }
}


class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");

        Owner owner1 = new Owner();
        owner1.Name = "Bill";

        owner1.MyPet = new Pet();
        owner1.MyPet.Name = "Gato";
        owner1.MyPet.AnimalType = "Cat";
        
        owner1.PrintInfo();

        Console.WriteLine();
    }
}