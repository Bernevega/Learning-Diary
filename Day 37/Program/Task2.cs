using System;
interface IDamageable
{
    void TakeDamage(int amount);
}

class Player : IDamageable
{
    public string Name { get; set; }
    public int Health { get; set; }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} just took {amount} damage! Health: {Health}");
    }
}

class Enemy : IDamageable
{
    public string Name { get; set; }
    public int Health { get; set; }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} just took {amount} damage! Health: {Health}");
    }
}

class Health
{
    static public void ApplyHit(IDamageable target)
    {
        target.TakeDamage(10);
    }
}
class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Player player1 = new Player();
        Enemy enemy1 = new Enemy();

        player1.Name = "Warrior";
        player1.Health = 100;

        enemy1.Name = "Bad Guy";
        enemy1.Health = 50;

        Health.ApplyHit(player1);
        Health.ApplyHit(enemy1);

        Console.WriteLine();
    }
}