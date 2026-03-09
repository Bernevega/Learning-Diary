using System;
class Task6
{
    public static void TaskSix()
    {
        int[] numbers = { 12, 7, 25, 4, 180 };

        int biggestNumber = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (biggestNumber < numbers[i])
            {
                biggestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The biggest number of this array is: {biggestNumber}");
        Console.WriteLine();
    }
}