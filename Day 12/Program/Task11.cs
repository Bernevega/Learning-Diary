using System;
using System.Collections.Generic;

class Person
{
    public string name;
    public int age;

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine();
    }

    public void HaveBirthday()
    {
        age++;
        Console.WriteLine($"Happy Birthday, {name}! You are now {age} years old");
        Console.WriteLine();
    }
}

class Task11
{
    public static void TaskEleven()
    {
        Person person1 = new Person();
        person1.name = "Anna";
        person1.age = 21;

        person1.PrintInfo();
        person1.HaveBirthday();
        person1.PrintInfo();
    }
}