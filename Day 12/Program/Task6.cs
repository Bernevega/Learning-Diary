using System;
using System.Collections.Generic;


class GameCharacter
{
    public string name;
    public int health;
    public int attackPower;

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Attack Power: {attackPower}");
        Console.WriteLine();
    }

    public void Attack()
    {
        Console.WriteLine($"{name} attacks with power {attackPower}!");
        Console.WriteLine();
    }
}

class Task6
{
    public static void TaskSix()
    {
        GameCharacter character1 = new GameCharacter();
        character1.name = "Warrior";
        character1.health = 100;
        character1.attackPower = 20;

        character1.PrintStats();
        character1.Attack();

        Console.WriteLine();

        GameCharacter character2 = new GameCharacter();
        character2.name = "Mage";
        character2.health = 50;
        character2.attackPower = 30;

        character2.PrintStats();
        character2.Attack();
    }
}