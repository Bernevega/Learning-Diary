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

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Book book1 = new Book();
        book1.Title = "The Grass Is Singing";
        book1.Author = "Doris Lessing";
        Console.WriteLine(book1.ToString());

        Console.WriteLine();
    }
}