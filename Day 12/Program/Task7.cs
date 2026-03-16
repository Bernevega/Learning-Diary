using System;
using System.Collections.Generic;

class Book
{
    public string title;
    public string author;
    public int pages;

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Pages: {pages}");
        Console.WriteLine();
    }
}

class Task7
{
    public static void TaskSeven()
    {
        Book book1 = new Book();
        Console.WriteLine("Please write the title:");
        book1.title = Console.ReadLine();
        Console.WriteLine("Please write the author:");
        book1.author = Console.ReadLine();
        Console.WriteLine("Please write the number of pages:");
        book1.pages = int.Parse(Console.ReadLine());
        Console.WriteLine();

        book1.PrintInfo();
    }
}