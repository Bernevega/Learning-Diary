using System;
class Task8
{
    public static void TaskEight()
    {
        Console.WriteLine("Please write your username:");
        string name = (Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Please write your password:");
        string pass = (Console.ReadLine());
        Console.WriteLine("");

        if (name == "admin" && pass == "1234")
            Console.WriteLine("Login successful.");
        else
            Console.WriteLine("Login failed.");
        Console.WriteLine("");
    }
}