using System;
using System.Collections.Generic;

class Movie
{
    private string title;
    private int year;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int Year 
    {
        get { return year; }
        set { year = value; }
    }

    public void PrintInfo()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Year);
        Console.WriteLine();
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("--- Task 4 ---");
        Movie movie1 = new Movie();
        Movie movie2 = new Movie();

        movie1.Title = "Movie 1";
        movie2.Title = "Movie 2";
        movie1.Year = 2026;
        movie2.Year = 2020;

        movie1.PrintInfo();
        movie2.PrintInfo();
    }
}