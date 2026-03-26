using System;
using System.Collections.Generic;

class PlayerStats
{
    public int Wins { get; set; }
    public int Losses { get; set; }

    public int TotalGames
    {
        get
        {
            if (Wins >= 0 && Losses >= 0)
                return Wins + Losses;
            else
                return -1;
        }
    }

    public string WinText
    {
        get
        {
            if (TotalGames >= 0)
                return $"Wins: {Wins}, Losses: {Losses}, Total: {TotalGames}.";
            else
                return "Error! Numbers cannot be negative.";
        }
    }
}

class Task9
{
    public static void TaskNine()
    {
        Console.WriteLine("--- Task 9 ---");

        PlayerStats player1 = new PlayerStats();
        player1.Wins = 43;
        player1.Losses = 0;
        Console.WriteLine(player1.WinText);
        Console.WriteLine();

        PlayerStats player2 = new PlayerStats();
        player2.Wins = -3;
        player2.Losses = 0;
        Console.WriteLine(player2.WinText);
        Console.WriteLine();
    }
}