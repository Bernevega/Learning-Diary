using System;
class Task5
{
    public static void TaskFive()
    {
        int num1 = 4;
        Console.WriteLine($"Original value: {num1}");

        num1 += 5;
        Console.WriteLine($"Value + 5: {num1}");

        num1 -= 8;
        Console.WriteLine($"Value - 8: {num1}");

        num1 *= 10;
        Console.WriteLine($"Value * 10: {num1}");

        num1 /= 9;
        Console.WriteLine($"Value / 9: {num1}");

        Console.WriteLine();
    }
}