using System;

struct PlayerStats
{
    public int Health { get; set; }
    public int Mana { get; set; }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        PlayerStats player1 = new PlayerStats();
        PlayerStats player2 = new PlayerStats();

        player1.Mana = 10;
        player1.Health = 100;

        player2 = player1;

        player2.Health = 15;

        Console.WriteLine($"Player 1 - Health: {player1.Health}, Mana: {player1.Mana}.");
        Console.WriteLine($"Player 2 - Health: {player2.Health}, Mana: {player2.Mana}.");

        // The values are different because structs create copies

        Console.WriteLine();
    }
}