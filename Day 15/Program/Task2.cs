using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Student's name: {Name}");
        Console.WriteLine($"Student's age: {Age}");
    }
}


class Task2
{
    public static void TaskTwo()
    {
        Student student1 = new Student();
        student1.Name = "Bob";
        student1.Age = 16;
        student1.ShowInfo();

        Console.WriteLine();
    }
}

