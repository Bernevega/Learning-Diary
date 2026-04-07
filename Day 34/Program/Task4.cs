using System;

class Person
{
    public virtual void Introduce()
    {
        Console.WriteLine("Hello, I am a person");
    }
}

class Student : Person
{
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("I am also a student");
    }
}
class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Person student1 = new Student();
        student1.Introduce();

        Console.WriteLine();
    }
}