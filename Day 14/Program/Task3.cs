using System;

class Student
{
    public string Name { get; set; }
    public char Grade { get; set; }
}

class Task3
{
    public static void TaskThree()
    {
        Student student1 = new Student();
        student1.Name = "Alice";
        student1.Grade = 'A';
        Console.WriteLine($"Student: {student1.Name}, Grade: {student1.Grade}");

        student1.Grade = 'B';
        Console.WriteLine($"Student: {student1.Name}, Grade: {student1.Grade}");

        Console.WriteLine();
    }
}