using System;
using System.Collections.Generic;

class Task2
{
    public static void TaskTwo()
    {
        Person person2 = new Person("Bob", 25);
        Person person3 = new Person("John", 62);

        Console.WriteLine($"Person 2: Name - {person2.name}, Age - {person2.age}");
        Console.WriteLine($"Person 3: Name - {person3.name}, Age - {person3.age}");

        Console.WriteLine();
    }
}

