using System;

class MainClass
{
    static void Main()
    {
        Task1.TaskOne();

        Task2.TaskTwo("Anna");

        Task3.TaskThree(3, 7);

        int result = Task4.TaskFour(4, 6);
        Console.WriteLine(result);
        Console.WriteLine();

        int square = Task5.TaskFive(5);
        Console.WriteLine(square);
        Console.WriteLine();

        bool isEven = Task6.TaskSix(4);
        Console.WriteLine(isEven);
        Console.WriteLine();

        string ageName = Task7.TaskSeven(50);
        Console.WriteLine(ageName);
        Console.WriteLine();

        Console.WriteLine("Please write the first number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please write the second number:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int prod = Task8.TaskEight(num1, num2);
        Console.WriteLine($"The result is: {prod}");
        Console.WriteLine();

        Console.WriteLine("Please write your name:");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Please write your surname");
        string surname = Console.ReadLine();
        Console.WriteLine();
        string fullName = Task9.TaskNine(name, surname);
        Console.WriteLine($"Your full name is: {fullName}");
        Console.WriteLine();

        Console.WriteLine("Please write today's temperature:");
        int temp = int.Parse(Console.ReadLine());
        string advice = Task10.TaskTen(temp);
        Console.WriteLine();
        Console.WriteLine(advice);
        Console.WriteLine();

        Console.WriteLine("Please write the first number:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Please write the second number:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int sum = Task11.Add(number1, number2);
        Console.WriteLine(sum);
        int sub = Task11.Subtract(number1, number2);
        Console.WriteLine(sub);
        int product = Task11.Multiply(number1, number2);
        Console.WriteLine(product);
    }
}