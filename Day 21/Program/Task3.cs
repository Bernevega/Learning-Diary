using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public Student(string name, int grade)
    {
        Name = name;
        if (grade >= 0 && grade <= 100)
            Grade = grade;
        else
            Grade = 0;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Hello, {Name}");
        Console.WriteLine($"Your grade: {Grade}");
        Console.WriteLine();
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");

        Student student1 = new Student("Alex", 95);
        Student student2 = new Student("Bob", 0);
        Student student3 = new Student("Mark", 100);
        Student student4 = new Student("Danny", -4);
        Student student5 = new Student("Carl", 150);

        student1.PrintInfo();
        student2.PrintInfo();
        student3.PrintInfo();
        student4.PrintInfo();
        student5.PrintInfo();
    }
}