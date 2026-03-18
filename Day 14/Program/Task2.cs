using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}


class Task2
{
    public static void TaskTwo()
    {
        Book book1 = new Book();
        book1.Title = "The Great Gatsby";
        book1.Pages = 180;
        Book book2 = new Book();
        book2.Title = "To Kill a Mockingbird";
        book2.Pages = 281;

        Console.WriteLine($"Book title: {book1.Title}, Pages: {book1.Pages}");
        Console.WriteLine($"Book title: {book2.Title}, Pages: {book2.Pages}");

        Console.WriteLine();
    }
}

