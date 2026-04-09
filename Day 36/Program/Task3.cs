using System;

interface IPlayable
{
    public void Play();
}

class Song : IPlayable
{
    public void Play()
    {
        Console.WriteLine("A song is playing...");
    }
}
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        IPlayable song1 = new Song();
        song1.Play();

        Console.WriteLine();
    }
}