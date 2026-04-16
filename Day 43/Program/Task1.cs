using System;

class Task1
{
    public static bool IsValidUsername(string username)
    {
        if (username == null)
            return false;

        if (username == "")
            return false;

        if (username.Length < 3)
            return false;

        return true;
    }

    public static void TaskOne()
    {
        Console.WriteLine("---Task 1---");

        Console.WriteLine($"Username \"Ann\" valid: {IsValidUsername("Ann")}");
        Console.WriteLine($"Username \"Al\" valid: {IsValidUsername("Al")}");
        Console.WriteLine($"Username \"\" valid: {IsValidUsername("")}");
        Console.WriteLine($"Username null valid: {IsValidUsername(null)}");

        Console.WriteLine();
    }
}
