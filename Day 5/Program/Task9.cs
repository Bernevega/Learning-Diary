using System;
class Task9
{
    public static void TaskNine()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Please write 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("");

        Console.WriteLine("Your new array:");
        for (int o = 0; o < numbers.Length; o++)
        {
            Console.Write(numbers[o] + " ");
        }
        Console.WriteLine("");
        Console.WriteLine("");

        int sum = 0;
        for (int u = 0; u < numbers.Length; u++)
        {
            sum += numbers[u];
        }
        Console.WriteLine($"Your number sum is: {sum}");
        Console.WriteLine("");

        int biggestNumber = numbers[0];
        for (int y = 0; y < numbers.Length; y++)
        {
            if (biggestNumber < numbers[y])
                biggestNumber = numbers[y];
        }

        Console.WriteLine($"The biggest number is: {biggestNumber}");
    }
}