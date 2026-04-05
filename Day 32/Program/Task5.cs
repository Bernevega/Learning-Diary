using System;
using System.Diagnostics;
using System.Xml.Linq;

class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Director: {Director}, Year: {Year}";
    }

    public override bool Equals(object? obj)
    {
        Movie? other = obj as Movie;

        if (other == null) 
            return false;

        else
            return Title == other.Title && Director == other.Director && Year == other.Year;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Director, Year);
    }
}
class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Movie movie1 = new Movie();
        movie1.Title = "The Danish Girl";
        movie1.Director = "Tom Hooper";
        movie1.Year = 2016;

        Movie movie2 = new Movie();
        movie2.Title = "The Danish Girl";
        movie2.Director = "Tom Hooper";
        movie2.Year = 2016;

        Movie movie3 = new Movie();
        movie3.Title = "Notting Hill";
        movie3.Director = "Roger Michell";
        movie3.Year = 1999;

        Console.WriteLine(movie1.ToString());

        Console.WriteLine($"Movie1 equals Movie2: {movie1.Equals(movie2)}");
        Console.WriteLine($"Movie1 equals Movie3: {movie1.Equals(movie3)}");

        Console.WriteLine($"Movie1 hash code: {movie1.GetHashCode()}");
        Console.WriteLine($"Movie2 hash code: {movie2.GetHashCode()}");
        Console.WriteLine($"Movie3 hash code: {movie3.GetHashCode()}");

        Console.WriteLine();
    }
}