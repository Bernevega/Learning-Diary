using System;
using System.Collections.Generic;

class Book
{
    public string title;
    public string author;
    public int pages;

    public void PrintInfo()
    {
        Console.WriteLine(title);
        Console.WriteLine(author);
        Console.WriteLine(pages);
        Console.WriteLine();
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("--- Task 2 ---");
        Book book1 = new Book();
        book1.title = "Title 1";
        book1.author = "Author 1";
        book1.pages = 50;
        book1.PrintInfo();

        Book book2 = new Book();
        book2.title = "Title 2";
        book2.author = "Author 2";
        book2.pages = 150;
        book2.PrintInfo();
    }
}