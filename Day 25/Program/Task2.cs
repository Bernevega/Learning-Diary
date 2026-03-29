using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

class Reader
{
    public string Name { get; set; }
    public Book FavBook { get; set; }

    public void PrintInfo()
    {
        if (Name == null)
            Console.WriteLine("The reader name does not exist yet");
        else if (FavBook == null)
            Console.WriteLine("The favourite book does not exist yet");
        else if (FavBook.Title == null)
            Console.WriteLine("The book title does not exist yet");
        else if (FavBook.Pages <= 0)
            Console.WriteLine("The pages count cannot be 0 or less");
        else
            Console.WriteLine($"{Name}'s favourite book is {FavBook.Title}. Pages: {FavBook.Pages}.");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");

        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.Pages = 125;

        Book book2 = new Book();
        book2.Title = "The Grass Is Singing";
        book2.Pages = 100;

        Reader reader1 = new Reader();
        reader1.Name = "Kyle";
        reader1.FavBook = book1;
        reader1.PrintInfo();

        reader1.FavBook = book2;
        reader1.PrintInfo();

        Console.WriteLine();
    }
}