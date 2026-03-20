using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int StudentId { get; set; }

    private List<int> grades = new List<int>();

    public void AddGrade(int grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade. Grade must be between 0 and 100.");
        }
    }

    public double GetAverage()
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        return grades.Average();
    }

    public int GetHighestGrade()
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        int highestGrade = grades[0];

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] > highestGrade)
            {
                highestGrade = grades[i];
            }
        }

        return highestGrade;
    }

    public int GetLowestGrade()
    {
        if (grades.Count == 0)
        {
            return 0;
        }

        int lowestGrade = grades[0];

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] < lowestGrade)
            {
                lowestGrade = grades[i];
            }
        }

        return lowestGrade;
    }

    public bool HasPassed()
    {
        return GetAverage() >= 50;
    }

    public void ShowGrades()
    {
        if (grades.Count == 0)
        {
            Console.WriteLine("No grades added yet.");
            return;
        }

        foreach (int grade in grades)
        {
            Console.Write(grade + " ");
        }

        Console.WriteLine();
    }

    public void ShowReport()
    {
        Console.WriteLine($"Hello, {Name}!");
        Console.WriteLine();
        Console.WriteLine($"Your ID: {StudentId}");
        Console.WriteLine("Your grades:");

        ShowGrades();

        if (grades.Count == 0)
        {
            Console.WriteLine("Average: No grades yet.");
            Console.WriteLine("Highest grade: No grades yet.");
            Console.WriteLine("Lowest grade: No grades yet.");
            Console.WriteLine("You've passed: False");
        }
        else
        {
            Console.WriteLine($"Your average: {GetAverage():F2}");
            Console.WriteLine($"Your highest grade: {GetHighestGrade()}");
            Console.WriteLine($"Your lowest grade: {GetLowestGrade()}");
            Console.WriteLine($"You've passed: {HasPassed()}");
        }
    }
}

class Task4
{
    public static void TaskFour()
    {
        Student student1 = new Student();

        Console.WriteLine("Hello! Please write your name:");
        student1.Name = Console.ReadLine();

        Console.WriteLine("Write your student ID:");
        student1.StudentId = int.Parse(Console.ReadLine());

        Console.WriteLine("How many grades do you have?");
        int gradesAmount = int.Parse(Console.ReadLine());

        for (int i = 0; i < gradesAmount; i++)
        {
            Console.WriteLine($"Write grade {i + 1}:");
            int grade = int.Parse(Console.ReadLine());
            student1.AddGrade(grade);
        }

        Console.WriteLine();
        Console.WriteLine("Here is your information:");
        student1.ShowReport();
        Console.WriteLine();
    }
}