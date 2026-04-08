using System;

abstract class Character
{
    public string Name { get; set; }

    public abstract void Attack();
}

class Warrior : Character
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} is swinging their hammer!");
    }
}
class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} is casting a spell!");
    }
}
class Archer : Character
{
    public override void Attack()
    {
        Console.WriteLine($"{Name} is shooting arrows!");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Character char1 = new Warrior();
        char1.Name = "Bob";
        Character char2 = new Mage();
        char2.Name = "Alex";
        Character char3 = new Archer();
        char3.Name = "Steve";

        Character[] characters = { char1, char2, char3 };

        foreach (Character character in characters)
        {
            character.Attack();
        }

        Console.WriteLine();
    }
}