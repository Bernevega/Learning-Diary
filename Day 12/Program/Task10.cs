using System;
using System.Collections.Generic;

class Movie
{
    public string title;
    public int year;
    public char rating;

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Rating: {rating}");
        Console.WriteLine();
    }
}

class Task10
{
    public static void TaskTen()
    {
        Movie[] movies = new Movie[3];
        movies[0] = new Movie();
        movies[0].title = "The Shawshank Redemption";
        movies[0].year = 1994;
        movies[0].rating = 'R';

        movies[1] = new Movie();
        movies[1].title = "The Godfather";
        movies[1].year = 1972;
        movies[1].rating = 'R';

        movies[2] = new Movie();
        movies[2].title = "The Dark Knight";
        movies[2].year = 2008;
        movies[2].rating = 'P';

        for (int i = 0; i < movies.Length; i++)
        {
            movies[i].PrintInfo();
        }

        Console.WriteLine();
    }
}