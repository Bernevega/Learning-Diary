using System;
using System.Collections.Generic;

class Pet
{
    public string Name { get; set; }
    public string Type { get; set; }
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }

    public Pet(string name, string type, int age)
    {
        Name = name;
        Type = type;
        Age = age;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} is a {Type} and is {Age} years old.");
    }

}

class Task10
{
    public static void TaskTen()
    {
        Pet pet1 = new Pet("Buddy", "Dog", 5);
        Pet pet2 = new Pet("Whiskers", "Cat", 3);
        pet1.ShowInfo();
        pet2.ShowInfo();
        Console.WriteLine();

        pet2.Age = -10;
        pet1.ShowInfo();
        pet2.ShowInfo();
    }
}