using System;

class Teacher
{
    public string Name { get; set; } 
    public string Subject { get; set; }

    public void PrintInfo()
    {
        if (Name == null)
            Console.WriteLine("Teacher name does not exist yet");
        else if (Subject == null)
            Console.WriteLine("Subject name does not exist yet");
        else
            Console.WriteLine($"{Name} is a {Subject} teacher.");
    }
}

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Teacher Teacher { get; set; }

    public void PrintInfo()
    {
        if (Name == null)
            Console.WriteLine("Student name does not exist yet");
        else if (Age <= 0 || Age > 100)
            Console.WriteLine("The age is invalid");
        else if (Teacher == null)
            Console.WriteLine("No teacher assigned");
        else
            Console.WriteLine($"{Name} is {Age} years old and has a teacher named {Teacher.Name} whose subject is {Teacher.Subject}.");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");
        
        Teacher teacher1 = new Teacher();
        teacher1.Name = "Mr. Smith";
        teacher1.Subject = "Physics";
        teacher1.PrintInfo();

        Student student1 = new Student();
        student1.Name = "Alex";
        student1.Age = 19;
        student1.Teacher = teacher1;
        student1.PrintInfo();

        Student student2 = new Student();
        student2.Name = "Maya";
        student2.Age = 19;
        student2.Teacher = teacher1;
        student2.PrintInfo();

        Console.WriteLine();
    }
}