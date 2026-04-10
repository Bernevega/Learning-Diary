using System;

interface IPlayable
{
    void Play();
}

class Song : IPlayable
{
    public void Play()
    {
        Console.WriteLine("A song is playing...");
    }
}

class Video : IPlayable
{
    public void Play()
    {
        Console.WriteLine("A video is playing...");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        IPlayable song1 = new Song();
        IPlayable video1 = new Video();

        song1.Play();
        video1.Play();

        Console.WriteLine();
    }
}