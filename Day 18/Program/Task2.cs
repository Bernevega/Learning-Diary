using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    
    public Person(string name)
    {
        this.Name = name;
    }

    public void ShowName()
    {
        Console.WriteLine($"Hello! Your name is {Name}!");
    }
}

class Student : Person
{
    public int Grade { get; set; }
    public Student(string name, int grade) : base(name)
    {
        this.Grade = grade;
    }

    public void ShowStudentInfo()
    {
        ShowName();
        Console.WriteLine($"Grade: {Grade}");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Student student1 = new Student("Pearl", 100);
        student1.ShowStudentInfo();

        Console.WriteLine();
    }
}