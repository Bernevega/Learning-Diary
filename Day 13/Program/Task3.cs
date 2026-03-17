using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Task3
{
    public static void TaskThree()
    {
        Book book1 = new Book();
        book1.Title = "The Great Gatsby";
        book1.Author = "F. Scott Fitzgerald";

        Console.WriteLine("Book Title: " + book1.Title);
        Console.WriteLine("Book Author: " + book1.Author);

        Console.WriteLine();
    }
}