using System;

class Task3
{
    public static int Multiply(int x, int y)
    {
        int answer = x * y;
        return answer;
    }

    public static void TaskThree()
    {
        Console.WriteLine("---Task 3---");

        int first = 6;
        int second = 7;
        int result = Multiply(first, second);

        Console.WriteLine($"Result: {result}");
        Console.WriteLine();

        Console.WriteLine();
    }
}