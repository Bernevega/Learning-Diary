using System;
using System.Collections.Generic;


class Player
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
    }
}

class Task5
{
    public static void TaskFive()
    {
        Player player1 = new Player("Alex");
        player1.Score = 120;
        Console.WriteLine($"Player: {player1.Name}, Score: {player1.Score}");

        Console.WriteLine();
    }
}