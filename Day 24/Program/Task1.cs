using System;

class Author
{
    public string Name { get; set; } 
    public string Country { get; set; }
}

class Book
{
    public string Title { get; set; }
    public Author BookAuthor { get; set; }

    public void PrintInfo()
    {
        if (Title == null)
            Console.WriteLine("The title does not exist yet");
        else if (BookAuthor == null)
            Console.WriteLine("The book author does not exist yet");
        else if (BookAuthor.Name == null)
            Console.WriteLine("The book author name does not exist yet");
        else if (BookAuthor.Country == null)
            Console.WriteLine("The book author country does not exist yet");
        else
            Console.WriteLine($"{Title} was written by {BookAuthor.Name}, {BookAuthor.Country}.");
    }
}

class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("--- Task 1 ---");
        
        Author author1 = new Author();
        author1.Name = "Camille Flammarion";
        author1.Country = "France";

        Book book1 = new Book();
        book1.Title = "Thunder and Lighting";
        book1.BookAuthor = author1;

        book1.PrintInfo();

        Console.WriteLine();
    }
}