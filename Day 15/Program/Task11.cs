using System;
using System.Collections.Generic;

class Calculator
{
    public static double Add(int a, int b)
    {
        return a + b;
    }

    public static double Subtract(int a, int b)
    {
        return a - b;
    }
    public static double Multiply(int a, int b)
    {
        return a * b;
    }

}
class Task11
{
    public static void TaskEleven()
    {
        Console.WriteLine("The sum of 1 and 5 is: " + Calculator.Add(1, 5));
        Console.WriteLine("The subtraction of 10 and 5 is: " + Calculator.Subtract(10, 5));
        Console.WriteLine("The multiplication of 3 and 5 is: " + Calculator.Multiply(3, 5));

        Console.WriteLine();
    }
}