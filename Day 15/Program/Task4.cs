using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void DescribeBook()
    {
        Console.WriteLine($"{Title} was written by {Author}.");
    }
}

class Task4
{
    public static void TaskFour()
    {
        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.Author = "J. K. Rowling";
        book1.DescribeBook();

        Console.WriteLine();
    }
}