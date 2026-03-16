using System;
class Student
{
    public string name;
    public int age;
    public char grade;

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine();
    }
}

class Task3
{
    public static void TaskThree()
    {
        Student student1 = new Student();
        student1.name = "Alice";
        student1.age = 20;
        student1.grade = 'A';

        student1.PrintInfo();
    }
}