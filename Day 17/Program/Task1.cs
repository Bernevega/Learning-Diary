using System;
using System.Collections.Generic;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Level { get; set; }
    public static List<Player> players = new List<Player>();

    public Player(string Name, int Health, int Mana, int Level)
    {
        this.Name = Name;
        this.Health = Health;
        this.Mana = Mana;
        this.Level = Level;
    }

    public void TakeDamage(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error! The damage cannot be 0 or less.");
        }
        else if (Health <= 0)
        {
            Console.WriteLine($"{Name} tried taking {amount} damage, but they're already dead!");
        }
        else if (Health - amount > 0)
        {
            Health -= amount;
            Console.WriteLine($"{Name} just took {amount} damage!");
        }
        else
        {
            Health = 0;
            Console.WriteLine($"{Name} just took {amount} damage and died!");
        }
    }

    public void Heal(int amount)
    {
        if (amount > 0)
            Health += amount;
        else
            Console.WriteLine("Error! The healing cannot be 0 or less.");
    }
    public void UseMana(int amount)
    {
        if (amount <= 0)
            Console.WriteLine("Error! The amount cannot be 0 or less.");
        else if (Mana - amount < 0)
            Console.WriteLine("Error! Not enough mana.");
        else
            Mana -= amount;
    }
    public void RestoreMana(int amount)
    {
        if (amount > 0)
            Mana += amount;
        else
            Console.WriteLine("Error! The mana cannot be 0 or less.");
    }
    public void LevelUp()
    {
        Level++;
        Health += 10;
        Mana += 5;
        Console.WriteLine($"{Name} just leveled up!");
        Console.WriteLine();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Your name: {Name}");
        Console.WriteLine($"Your health: {Health}");
        Console.WriteLine($"Your mana: {Mana}");
        Console.WriteLine($"Your level: {Level}");
        Console.WriteLine();
    }
}

class Task1
{
    public static void TaskOne()
    {
        Player player1 = new Player("Alex", 100, 5, 15);
        Player player2 = new Player("Karen", 50, 15, 1);

        player1.PrintInfo();
        player2.PrintInfo();
        player1.LevelUp();
        player1.LevelUp();
        player2.LevelUp();
        player1.TakeDamage(20);
        player1.Heal(10);
        player1.UseMana(3);
        player1.RestoreMana(5);
        player2.TakeDamage(15);
        player2.Heal(5);
        player2.UseMana(10);
        player2.RestoreMana(2);
        player1.PrintInfo();
        player2.PrintInfo();

        Player.players.Add(player1);
        Player.players.Add(player2);
        Player.players.Add(new Player("Sara", 70, 35, 10));

        for (int i = 0; i < Player.players.Count; i++)
        {
            Player.players[i].PrintInfo();
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}