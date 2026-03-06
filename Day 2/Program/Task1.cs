using System;
class Task1
{
    public static void TaskOne()
    {
        Console.WriteLine("Please write the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please write the second number:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int dif = num1 - num2;
        int prod = num1 * num2;
        int div = num1 / num2;
        int rem = num1 % num2;

        Console.WriteLine("");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {dif}");
        Console.WriteLine($"Product: {prod}");
        Console.WriteLine($"Division: {div}");
        Console.WriteLine($"Remainder: {rem}");
        Console.WriteLine("");
    }
}