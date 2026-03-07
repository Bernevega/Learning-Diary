using System;
class Task6
{
    public static void TaskSix()
    {
        int userTries = 3;
        int allowedTries = 3;
        string correctPass = "cat123";

        for (int i = 0; i < allowedTries; i++)
        {
            Console.WriteLine("Please enter your password:");
            string userPass = Console.ReadLine();
            userTries--;
            Console.WriteLine("");

            if (userPass == correctPass)
            {
                Console.WriteLine("Access granted!");
                break;
            }

            else if (userTries < allowedTries && userTries != 0)
            {
                Console.WriteLine("Wrong password!");
                Console.WriteLine($"You have {userTries} more attempts.");
                Console.WriteLine("");
            }

            else
                Console.WriteLine("Access denied");
        }
        Console.WriteLine("");
    }
}