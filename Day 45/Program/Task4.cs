using System;

class Calculator
{
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        try
        {
            int result = Calculator.Divide(10, 0);
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by 0");
        }

        Console.WriteLine();
    }
}