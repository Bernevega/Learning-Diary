using System;
class Task1
{
    public static void TaskOne()
    {
        int[] array = { 1, 3, 5, 10, 15 };

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();

        Console.WriteLine(array[0]);
        Console.WriteLine();

        Console.WriteLine(array[array.Length - 1]);
        Console.WriteLine();
    }
}