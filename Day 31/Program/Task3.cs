using System;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Book book1 = new Book();
        book1.Title = "Harry Potter";
        book1.Pages = 450;

        Book book2 = book1;
        book2.Title = "Hobbit";

        Console.WriteLine($"Book 1: {book1.Title}, {book1.Pages} pages");
        Console.WriteLine($"Book 2: {book2.Title}, {book2.Pages} pages");

        Console.WriteLine($"The books are the same (==): {book1 == book2}");
        Console.WriteLine($"The books are the same (Equals()): {book1.Equals(book2)}");
        Console.WriteLine($"The books are the same (object.ReferenceEquals()): {object.ReferenceEquals(book1, book2)}");

        Console.WriteLine();
    }
}