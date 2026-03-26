using System;
using System.Collections.Generic;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");

        Person person1 = new Person();
        person1.FirstName = "John";
        person1.LastName = "Smith";
        Console.WriteLine($"Your first name - {person1.FirstName}. Your last name - {person1.LastName}.");
        Console.WriteLine($"Your full name - {person1.FullName}.");

        Console.WriteLine();
    }
}