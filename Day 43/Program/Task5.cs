using System;

class FileDownloader
{
    private bool isConnected;

    public void Connect()
    {
        isConnected = true;
        Console.WriteLine("Connected to server.");
    }

    public void DownloadFile()
    {
        if (!isConnected)
            throw new InvalidOperationException("Cannot download file before connecting.");

        Console.WriteLine("Downloading file...");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        FileDownloader downloader = new FileDownloader();

        try
        {
            downloader.DownloadFile();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        downloader.Connect();
        downloader.DownloadFile();

        Console.WriteLine();
    }
}