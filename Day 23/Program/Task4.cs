using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }

    public bool IsEqual(Book obj1, Book obj2)
    {
        if (obj1 == obj2)
            return true;
        else
            return false;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("--- Task 4 ---");

        Book book1 = new Book();
        Book book2 = new Book();
        book1.Title = "Harry Potter";
        book2.Title = "Harry Potter";
        book1.Pages = 156;
        book2.Pages = 156;

        Console.WriteLine($"Books 1 and 2 are equal: {book1.IsEqual(book1, book2)}.");

        Console.WriteLine();
    }
}