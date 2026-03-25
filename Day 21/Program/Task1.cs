using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        if (age > 0)
            Age = age;
        else
            Age = 0;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Hello, {Name}");
        Console.WriteLine($"You are {Age} years old");
        Console.WriteLine();
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");

        Person person1 = new Person("Masha", 8);
        Person person2 = new Person("Pasha", 0);
        Person person3 = new Person("Dasha", -10);

        person1.ShowInfo();
        person2.ShowInfo();
        person3.ShowInfo();
    }
}