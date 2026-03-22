using System;
using System.Collections.Generic;

class Character
{
    protected int health;
    public Character(int health)
    {
        if (health > 0)
            this.health = health;
    }

    public void ShowHealth()
    {
        Console.WriteLine($"Health: {health}.");
    }
}

class Warrior : Character
{
    public Warrior(int health) : base(health)
    {

    }

    public void TakeDamage(int amount)
    {
        if (amount < 0)
            Console.WriteLine("You cannot take less than 0 damage!");
        else if (health <= 0)
            Console.WriteLine("You cannot take damage if you are dead!");
        else if (health - amount > 0)
        {
            this.health -= amount;
            Console.WriteLine($"You took {amount} damage!");
        }
        else
        {
            health = 0;
            Console.WriteLine($"You took {amount} damage and died!");
        }
    }
}

class Task3
{
    public static void TaskThree()
    {
        Warrior warrior1 = new Warrior(100);
        warrior1.ShowHealth();
        warrior1.TakeDamage(5);
        warrior1.ShowHealth();

        Console.WriteLine();
    }
}