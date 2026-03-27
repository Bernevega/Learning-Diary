using System;
using System.Collections.Generic;

class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");

        Dog dog1 = new Dog();
        Dog dog2 = dog1;

        dog1.Name = "Buddy";
        dog1.Age = 10;
        dog2.Name = "Wolfy";
        dog2.Age = 3;

        Console.WriteLine($"Dog 1: {dog1.Name}, {dog1.Age}");
        Console.WriteLine($"Dog 2: {dog2.Name}, {dog2.Age}");

        Console.WriteLine();
    }
}