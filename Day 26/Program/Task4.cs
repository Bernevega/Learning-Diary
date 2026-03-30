using System;

class Movie
{
    private string title;
    private int year;

    public string Title
    {
        get { return title; }
        set
        {
            if (value == null)
                title = "Null";
            else
                title = value;
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1500)
                year = 1500;
            else
                year = value;
        }
    }

    public Movie(string title, int year)
    {
        Title = title;
        Year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Title}, {Year}");
    }
}

class Task4
{
    public static void TaskFour()
    {
        Movie movie1 = new Movie("Harry Potter", 2005);
        Movie movie2 = new Movie("Titanic", 1997);

        movie1.PrintInfo();
        movie2.PrintInfo();
    }
}