using System;
using System.Collections.Generic;

class Person
{
    private int age;
    public void SetAge(int newAge)
    {
        if (newAge >= 0 && newAge <= 120)
            age = newAge;
        else
            Console.WriteLine("Error!");
    }
    public int GetAge()
    {
        return age;
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");
        Person person1 = new Person();
        Person person2 = new Person();

        person1.SetAge(25);
        Console.WriteLine(person1.GetAge());
        Console.WriteLine();

        person2.SetAge(-1);
        Console.WriteLine(person2.GetAge());

        Console.WriteLine();
    }
}