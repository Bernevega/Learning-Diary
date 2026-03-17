using System;
using System.Collections.Generic;


class Student
{
    public string Name { get; set; }
    public char Grade { get; set; }

    public Student(string name, char grade)
    {
        Name = name;
        Grade = grade;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name} has grade {Grade}");
        Console.WriteLine();
    }
}

class Task5
{
    public static void TaskFive()
    {
        Student student1 = new Student("Alice", 'A');
        student1.ShowInfo();
    }
}