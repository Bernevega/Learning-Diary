using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Person
{
    public string Name { get; set; }
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
}
class Task6
{
    public static void TaskSix()
    {
        Person person1 = new Person();
        Console.WriteLine("Please write your name:");
        person1.Name = Console.ReadLine();
        Console.WriteLine("Please write your age:");
        person1.Age = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine($"Hi {person1.Name}! You are {person1.Age} years old.");

        Console.WriteLine();
    }
}