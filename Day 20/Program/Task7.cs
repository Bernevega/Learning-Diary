using System;
using System.Collections.Generic;

class GameCharacter
{
    private int health = 100;
    private bool isAlive = true;
    public string Name { get; set; }
    public string ClassType { get; set; }

    public void TakeDamage(int amount)
    {
        if (health == 0)
        {
            Console.WriteLine($"{Name} cannot take damage since they are dead!");
            Console.WriteLine();
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Cannot take 0 or less damage!");
            Console.WriteLine();
        }
        else if (amount >= health)
        {
            health = 0;
            isAlive = false;
            Console.WriteLine($"{Name} took {amount} damage and died!");
            Console.WriteLine();
        }
        else
        {
            health -= amount;
            Console.WriteLine($"{Name} took {amount} damage!");
            Console.WriteLine();
        }
    }

    public void Heal(int amount)
    {
        if (!isAlive)
        {
            Console.WriteLine($"{Name} cannot be healed because they are dead!");
            Console.WriteLine();
        }
        else if (health == 100)
        {
            Console.WriteLine($"{Name} cannot be healed because they already have max HP!");
            Console.WriteLine();
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Cannot heal 0HP or less!");
            Console.WriteLine();
        }
        else if (amount + health >= 100)
        {
            health = 100;
            Console.WriteLine($"{Name} healed {amount}HP and was fully restored!");
            Console.WriteLine();
        }
        else
        {
            health += amount;
            Console.WriteLine($"{Name} healed {amount}HP!");
            Console.WriteLine();
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine($"HP: {health}");
        Console.WriteLine($"Is alive: {isAlive}");
        Console.WriteLine();
    }
}

class Task7
{
    public static void TaskSeven()
    {
        Console.WriteLine("--- Task 7 ---");
        GameCharacter char1 = new GameCharacter();
        char1.Name = "Mark";
        char1.TakeDamage(0);
        char1.TakeDamage(50);

        char1.ShowInfo();

        char1.Heal(0);
        char1.Heal(10);
        char1.Heal(100);
        char1.Heal(100);
        char1.TakeDamage(1000000);
        char1.Heal(100);

        char1.ShowInfo();
    }
}