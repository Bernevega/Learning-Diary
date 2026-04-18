using System;

class PlayerLoader
{
    public static string GetPlayerName(string[] names, int index)
    {
        return names[index];
    }
}

class Game
{
    public static void StartGame()
    {
        string[] playerNames = { "Lena", "Oskar", "Mira" };
        string selectedName = PlayerLoader.GetPlayerName(playerNames, 1);

        Console.WriteLine("Loaded player: " + selectedName);
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Game.StartGame();
    }
}