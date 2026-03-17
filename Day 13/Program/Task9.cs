using System;
using System.Collections.Generic;

class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName
    {
        get { return FirstName + " " + LastName; }
    }
}
class Task9
{
    public static void TaskNine()
    {
        User user1 = new User();
        user1.FirstName = "John";
        user1.LastName = "Doe";
        Console.WriteLine(user1.FullName);

        Console.WriteLine();
    }
}