using System;
using System.Collections.Generic;
class Task8
{
    public static void TaskEight()
    {
        List<string> animals = new List<string> { "Cat", "Dog", "Cow", "Goat" };

        Console.WriteLine($"The value \"Cat\" exists: {animals.Contains("Cat")}");
        Console.WriteLine($"The value \"Mouse\" exists: {animals.Contains("Mouse")}");

        Console.WriteLine();
    }
}