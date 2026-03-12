using System;
class Task8
{
    public static void TaskEight()
    {
        int[,] numbers =
        {
            { 5, 8, 2 },
            { 9, 1, 7 }
        };

        Console.WriteLine("Please enter a number to search in the array:");
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine();

        bool isExisting = false;
        int row = 0;
        int col = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (target == numbers[i, j])
                {
                    isExisting = true;
                    row = i;
                    col = j;
                    break;
                }
            }
        }

        if (isExisting)
        { 
            Console.WriteLine("The target number exists in the array!");
            Console.WriteLine($"[{row}, {col}]");
        }
        else
            Console.WriteLine("Not found");

        Console.WriteLine();
    }
}