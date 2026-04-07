using System;

class Character
{

    public virtual void Attack()
    {
        Console.WriteLine("Character attacks");
    }
}

class Mage : Character
{
    public override void Attack()
    {
        Console.WriteLine("Mage casts a spell");
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Character fighter1 = new Mage();
        fighter1.Attack();

        Console.WriteLine();
    }
}