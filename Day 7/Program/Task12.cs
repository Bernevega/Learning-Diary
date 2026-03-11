using System;
using System.Xml.Linq;
class Task12
{
    public static void TaskTwelve()
    {
        Console.WriteLine("How many numbers in the array?:");
        int amount = int.Parse(Console.ReadLine());
        int[] numbers = new int[amount];
        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Please write a number:");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        Console.WriteLine("Your array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine();

        Console.WriteLine("Your array's sum:");
        Console.WriteLine(sum);
    }
}