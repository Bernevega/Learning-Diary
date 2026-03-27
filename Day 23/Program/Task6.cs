using System;

class Player
{
    public string Name { get; set; }
    public int Health { get; set; }

    public static void PrintInfo(Player player)
    {
        {
            if (player == null)
                Console.WriteLine("The player object does not exist yet.");
            else if (player.Name == null)
                Console.WriteLine("The player name does not exist yet.");
            else
                Console.WriteLine($"{player.Name}, {player.Health}.");
        }
    }
}

class Task6
{
    public static void TaskSix()
    {
        Console.WriteLine("--- Task 6 ---");

        Player player1 = null;
        Player.PrintInfo(player1);

        Player player2 = new Player();
        player2.Name = "Alex";
        player2.Health = 100;
        Player.PrintInfo(player2);

        Console.WriteLine();
    }
}