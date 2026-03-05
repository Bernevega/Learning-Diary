using System;

class Task3
{
    public static void TaskThree()
    {
        string userName;
        int userAge;
        int favUserNumber;

        Console.WriteLine("TASK 3");
        Console.WriteLine("Please write your name:");
        userName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Please write your age:");
        userAge = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please write your favourite number:");
        favUserNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("YOUR INFO:");
        Console.WriteLine($"Your name: {userName}");
        Console.WriteLine($"Your age: {userAge}");
        Console.WriteLine($"Your favourite number: {favUserNumber}");
        Console.WriteLine("");
    }
}