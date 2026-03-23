using System;
using System.Collections.Generic;

class Player
{
    public string Name { get; set; }
    public int Health { get; private set; } = 50;

    public void TakeDamage(int amount)
    {
        if (amount >= Health)
        {
            Health = 0;
            Console.WriteLine($"{Name} took {amount} damage and died!");
            Console.WriteLine();
        }
        else if (amount > 0)
        {
            Health -= amount;
            Console.WriteLine($"{Name} just took {amount} damage!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Damage must be greater than 0!");
            Console.WriteLine();
        }
    }

    public void Heal(int amount)
    {
        if (Health + amount > 100)
        {
            Health = 100;
            Console.WriteLine($"{Name} was fully healed!");
            Console.WriteLine();
        }
        else if (amount > 0)
        {
            Health += amount;
            Console.WriteLine($"{Name} healed {amount} HP!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Heal must be greater than 0!");
            Console.WriteLine();
        }
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();

        player1.Name = "Warrior";
        player2.Name = "Mage";
        player3.Name = "Bard";

        player1.TakeDamage(100);
        player2.TakeDamage(25);
        player3.TakeDamage(-5);

        player1.Heal(1000);
        player2.Heal(25);
        player3.Heal(-5);
    }
}