using System;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public override bool Equals(object? obj)
    {
        Student? other = obj as Student;

        if (other == null)
            return false;

        return Name == other.Name && Grade == other.Grade;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Grade);
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Student student1 = new Student();
        student1.Name = "Alex";
        student1.Grade = 63;

        Student student2 = new Student();
        student2.Name = "Alex";
        student2.Grade = 63;

        Student student3 = new Student();
        student3.Name = "Bob";
        student3.Grade = 24;

        Console.WriteLine($"Student1 and Student2 are equal: {student1.Equals(student2)}");
        Console.WriteLine($"Student2 and Student3 are equal: {student2.Equals(student3)}");

        Console.WriteLine();
    }
}