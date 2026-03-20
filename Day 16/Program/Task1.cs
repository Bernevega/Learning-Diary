using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    private int age;

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
            age = newAge;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Hello, {Name}! You are {age} years old.");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Person person1 = new Person();
        person1.Name = "Greg";
        person1.SetAge(65);
        person1.ShowInfo();
        person1.SetAge(-10);
        person1.ShowInfo();
        person1.SetAge(56);
        person1.ShowInfo();

        Console.WriteLine();
    }
}