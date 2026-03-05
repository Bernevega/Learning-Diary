using System;

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("Please write the first number:");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please write the second number:");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Please write the operator:");
        char op = char.Parse(Console.ReadLine();

        float res = 0;

        switch (op)
        {
            case '+':
                res = num1 + num2;
                break;

            case '-':
                res = num1 - num2;
                break;
            case '*':
                res = num1 * num2;
                break;
            case '/':
                res = num1 / num2;
                break;
        }

        Console.WriteLine($"The result of the calculation is {res}.");
    }
}