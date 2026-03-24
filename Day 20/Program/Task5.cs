using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Grade);
        Console.WriteLine();
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("--- Task 5 ---");
        Student student1 = new Student();
        student1.Name = "Bob";
        student1.Grade = 5;
        student1.PrintInfo();
    }
}