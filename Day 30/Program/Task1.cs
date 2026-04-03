using System;

record Book(string Title, string Author);

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Book book1 = new Book("The Hobbit", "John Ronald Reuel Tolkien");
        Book book2 = new Book("The Hobbit", "John Ronald Reuel Tolkien");
        Console.WriteLine(book1);
        Console.WriteLine(book2);

        if (book1 == book2)
            Console.WriteLine("Books are the same.");
        else
            Console.WriteLine("Books are not the same.");

        // Books are the same because they come from a record and have the same values.

        Console.WriteLine();
    }
}