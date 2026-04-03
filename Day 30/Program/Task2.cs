using System;

record Student
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Student student1 = new Student
        {
            Name = "Ann",
            Age = 21
        };

        Console.WriteLine(student1);

        // Init allows assignment during creation but not later because the record values can only be set once and are never changed later.
        // Init allows assignment only during creation
        // Set allows future changes

        Console.WriteLine();
    }
}