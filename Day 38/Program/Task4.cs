using System;

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        object command = "stop";

        switch (command)
        {
            case "start":
                {
                    Console.WriteLine("Game started");
                    break;
                }
            case "stop":
                {
                    Console.WriteLine("Game stopped");
                    break;
                }
            case "pause":
                {
                    Console.WriteLine("Game paused");
                    break;
                }
            default:
                {
                    Console.WriteLine("Unknown command");
                    break;
                }
        }

        Console.WriteLine();
    }
}