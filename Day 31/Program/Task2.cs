using System;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.Pages = 125;

        Book book2 = new Book();
        book2.Title = "Harry Potter";
        book2.Pages = 125;

        Console.WriteLine($"The books are the same (==): {book1 == book2}");
        Console.WriteLine($"The books are the same (Equals()): {book1.Equals(book2)}");
        Console.WriteLine($"The books are the same (object.ReferenceEquals()): {object.ReferenceEquals(book1, book2)}");

        Console.WriteLine();
    }
}