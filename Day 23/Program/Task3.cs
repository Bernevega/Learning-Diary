using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public bool IsEqual(object obj1, object obj2)
    {
        {
            if (obj1 == obj2)
                return true;
            else
                return false;
        }
    }

}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");

        Student student1 = new Student();
        Student student2 = student1;
        
        Console.WriteLine($"Student 1 and 2 are equal: {student1.IsEqual(student1, student2)}.");

        Console.WriteLine();
    }
}