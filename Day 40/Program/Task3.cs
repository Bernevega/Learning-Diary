using System;

class Task3
{
    public static void DivideNumbers()
    {
        Console.WriteLine("Please enter the first number:");
        string num1 = Console.ReadLine();
        Console.WriteLine("Please enter the second number:");
        string num2 = Console.ReadLine();

        bool success1 = int.TryParse(num1, out int result1);
        bool success2 = int.TryParse(num2, out int result2);

        if (success1 && success2)
        {
            Console.WriteLine();
            Console.WriteLine($"Your first number: {result1}");
            Console.WriteLine($"Your second number: {result2}");

            if (result2 != 0)
                Console.WriteLine($"The result of the division: {result1 / result2}");
            else
                Console.WriteLine("Cannot divide by 0!");
        }
        Console.WriteLine();
    }
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        DivideNumbers();
        
    }
}