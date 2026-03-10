using System;
class Task11
{
    public static void TaskEleven()
    {
        string name = "Bob";
        string rank = "Soldier";
        int lvl = 5;
        int health = 80;
        char grade = 'A';
        bool isAlive = true;

        const int maxHealth = 100;


        Console.WriteLine($"Hello, {name} the {rank}!");
        Console.WriteLine($"You are level {lvl}.");
        Console.WriteLine($"You have {health} out of {maxHealth} HP - {maxHealth - health} missing.");
        Console.WriteLine($"You currently have grade {grade}.");
        Console.WriteLine($"You are alive: {isAlive}");
    }
}