using System;
class Task8
{
    public static void TaskEight()
    {
        string name = "Mark";
        int age = 10;
        string city = "New York";

        Console.WriteLine("With interpolation:");
        Console.WriteLine($"Hello! My name is {name}, I am {age} years old and I am from {city}");
        Console.WriteLine();

        Console.WriteLine("With concatenation:");
        Console.WriteLine("Hello! My name is " + name + ", I am " + age + " years old and I am from " + city);
        Console.WriteLine();
    }
}