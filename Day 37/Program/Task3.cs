using System;
interface IPrintable
{
    void PrintInfo();
}

class Book : IPrintable
{
    public string Title { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Book: {Title}");
    }
}
class Movie : IPrintable
{
    public string Title { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Movie: {Title}");
    }
}
class Game : IPrintable
{
    public string Title { get; set; }
    public void PrintInfo()
    {
        Console.WriteLine($"Game: {Title}");
    }
}
class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Book book1 = new Book();
        book1.Title = "Harry Potter";

        Movie movie1 = new Movie();
        movie1.Title = "Hobbit";

        Game game1 = new Game();
        game1.Title = "Undertale";

        IPrintable[] prints = new IPrintable[3];
        prints[0] = book1;
        prints[1] = movie1;
        prints[2] = game1;

        foreach (IPrintable print in prints)
        {
            print.PrintInfo();
        }

        Console.WriteLine();
    }
}