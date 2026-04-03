using System;
using System.Xml.Linq;

record Team(string Name, string[] Members);
class TeamPrinter
{
    public static void PrintInfo(Team team)
    {
        Console.WriteLine($"Team name: {team.Name}");
        Console.WriteLine($"Members: {string.Join(", ", team.Members)}");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        string[] teamMembers = { "Bob", "Alex", "Vanessa" };
        Team team1 = new Team("Winners", teamMembers);
        TeamPrinter.PrintInfo(team1);

        teamMembers[2] = "Guy";
        TeamPrinter.PrintInfo(team1);

        // The record object itself did not change reference
        // The array is a reference type, so changing it is allowed
        // Shallow immutability means that the outer objects looks immutable but the objects stored inside can still be changed (like the array)
        // For example, changing the name of the team is not allowed

        Console.WriteLine();
    }
}