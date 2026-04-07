using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}";
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        Book book1 = new Book();
        book1.Title = "The Hobbit";
        book1.Author = "Tolkien";
        Console.WriteLine(book1);

        Console.WriteLine();
    }
}