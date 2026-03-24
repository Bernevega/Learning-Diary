using System;
using System.Collections.Generic;

class Book2
{
   public string Title { get; set; }
   public string Author { get; set; }
   public int Pages { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Author);
        Console.WriteLine(Pages);
        Console.WriteLine();
    }
}

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");
        Book2 book1 = new Book2();
        book1.Title = "Title 3";
        book1.Author = "Author 3";
        book1.Pages = 100;
        book1.PrintInfo();

        Book2 book2 = new Book2();
        book2.Title = "Title 4";
        book2.Author = "Author 4";
        book2.Pages = 40;
        book2.PrintInfo();
    }
}