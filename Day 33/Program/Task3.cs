using System;

class Person
{
    protected int age;
    public string Name { get; set; }

    public void SetAge(int value)
    {
        if (value <= 0 || value >= 130)
        {
            Console.WriteLine($"Invalid age!");
            age = 0;
        }
        else
            age = value;
    }
}

class Student : Person
{
    public void ShowAge()
    {
        Console.WriteLine($"{Name} is {age} years old");
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Student student1 = new Student();
        student1.Name = "Alex";
        student1.SetAge(-10);
        student1.SetAge(0);
        student1.SetAge(170);
        student1.SetAge(19);
        student1.ShowAge();

        Console.WriteLine();
    }
}