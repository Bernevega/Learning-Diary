using System;
using System.Collections.Generic;

class Player
{
    public string Name {  get; set; }
    public int Score { get; set; }

    public void AddScore(int points)
    {
        Score += points;
        Console.WriteLine($"You received {points} points.");
    }
    public void ShowScore()
    {
        Console.WriteLine($"Your score: {Score}");
    }
    public static void ShowGameRules()
    {
        Console.WriteLine($"Game rules: \n1) Don't cheat. \n2) Enjoy!");
        Console.WriteLine();
    }
}
class Task14
{
    public static void TaskFourteen()
    {
        Player player1 = new Player();
        player1.Name = "Sophie";
        player1.Score = 123;

        Player.ShowGameRules();
        player1.ShowScore();
        player1.AddScore(5);
        player1.ShowScore();
        player1.AddScore(14);
        player1.ShowScore();

        Console.WriteLine();
    }
}