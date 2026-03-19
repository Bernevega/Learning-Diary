using System;
using System.Collections.Generic;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public void Play()
    {
        Console.WriteLine($"Now playing: {Title} by {Artist}");
    }
}

class Task8
{
    public static void TaskEight()
    {
        Song song1 = new Song();
        song1.Title = "Little Sadie";
        song1.Artist = "Crooked Still";
        song1.Play();

        Song song2 = new Song();
        song2.Title = "A Night Like This";
        song2.Artist = "The Cure";
        song2.Play();

        Console.WriteLine();
    }
}