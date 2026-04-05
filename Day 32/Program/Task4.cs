using System;


class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Student student1 = new Student();
        student1.Name = "Alex";
        student1.Grade = 63;

        Student student2 = new Student();
        student2.Name = "Alex";
        student2.Grade = 63;

        Console.WriteLine($"Student1 equals Student2: {student1.Equals(student2)}");
        Console.WriteLine($"Student1 hash code: {student1.GetHashCode()}");
        Console.WriteLine($"Student2 hash code: {student2.GetHashCode()}");

        Console.WriteLine();
    }
}