using System;
using System.Collections.Generic;

class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    public bool IsDead
    {
        get
        {
            if (Health <= 0)
                return true;
            else
                return false;
        }
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("--- Task 5 ---");

        GameCharacter char1 = new GameCharacter();
        char1.Name = "Warrior";
        char1.Health = 50;
        Console.WriteLine($"{char1.Name} has {char1.Health}HP.");
        Console.WriteLine($"They are dead: {char1.IsDead}.");
        Console.WriteLine();

        GameCharacter char2 = new GameCharacter();
        char2.Name = "Mage";
        char2.Health = 0;
        Console.WriteLine($"{char2.Name} has {char2.Health}HP.");
        Console.WriteLine($"They are dead: {char2.IsDead}.");

        Console.WriteLine();
    }
}