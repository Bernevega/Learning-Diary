using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }

    public bool IsPassing
    {
        get
        {
            if (Score >= 50)
                return true;
            else
                return false;
        }
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("--- Task 4 ---");

        Student student1 = new Student();
        student1.Name = "Bob";
        student1.Score = 50;
        Console.WriteLine($"Hello, {student1.Name}! Your have a score of {student1.Score}.");
        Console.WriteLine($"You are passing: {student1.IsPassing}.");

        Console.WriteLine();
    }
}