using System;

class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        Console.Write("Enter the first number: ");
        string firstInput = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string secondInput = Console.ReadLine();

        bool firstValid = double.TryParse(firstInput, out double firstNumber);
        bool secondValid = double.TryParse(secondInput, out double secondNumber);

        if (!firstValid || !secondValid)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        else if (secondNumber == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        else
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {result}");
        }

        Console.WriteLine();
    }
}