using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        static void DescribeValue(object value)
        {
            switch (value)
            {
                case int number:
                    Console.WriteLine($"This is an integer: {number}");
                    break;

                case string text:
                    Console.WriteLine($"This is a string: {text}");
                    break;
                case bool boolean:
                    Console.WriteLine($"This is a boolean: {boolean}");
                    break;
                case null:
                    Console.WriteLine($"This value is null");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }

        DescribeValue(25);
        DescribeValue("hello");
        DescribeValue(true);
        DescribeValue(null);
        DescribeValue(3.14);

        Console.WriteLine();
    }
}