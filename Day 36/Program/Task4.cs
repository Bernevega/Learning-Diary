using System;
using System.Drawing;

interface IPrintable
{
    public void Print();
}

class Document : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing a document...");
    }
}
class Photo : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing a photo...");
    }
}

class Printer
{
    public void StartPrinting(IPrintable item)
    {
        item.Print();
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        Printer printer1 = new Printer();
        IPrintable doc1 = new Document();
        IPrintable photo1 = new Photo();

        printer1.StartPrinting(doc1);
        printer1.StartPrinting(photo1);

        Console.WriteLine();
    }
}