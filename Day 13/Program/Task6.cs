using System;
using System.Collections.Generic;


class Player
{
    private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0)
                health = value;
        }
    }
}

class Task6
{
    public static void TaskSix()
    {
        Player player = new Player();
        player.Health = 100;
        Console.WriteLine($"Player Health: {player.Health}");

        player.Health = -50;
        Console.WriteLine($"Player Health after setting to -50: {player.Health}");

        Console.WriteLine();
    }
}