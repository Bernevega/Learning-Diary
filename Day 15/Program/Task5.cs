using System;
using System.Collections.Generic;

class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"Your health after taking {amount} damage is {Health}.");
    }
}

class Task5
{
    public static void TaskFive()
    {
        GameCharacter gamechar1 = new GameCharacter();
        gamechar1.Health = 120;
        gamechar1.Name = "Warrior";
        gamechar1.TakeDamage(10);
        gamechar1.TakeDamage(20);
        gamechar1.TakeDamage(50);

        Console.WriteLine();
    }
}