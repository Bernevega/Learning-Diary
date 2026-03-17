using System;
using System.Collections.Generic;

class Person
{
    public string name;
    public int age;

    public Person(string Name, int Age)
    {
        name = Name;
        age = Age;
    }
}

class Task1
{
    public static void TaskOne()
    {
        Person person1 = new Person("Alice", 30);

        Console.WriteLine($"Name: {person1.name}");
        Console.WriteLine($"Age: {person1.age}");

        Console.WriteLine();
    }
}