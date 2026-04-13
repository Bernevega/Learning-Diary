using System;

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        int size = 5;
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Please enter an index:");
            string num = Console.ReadLine();
            bool success = int.TryParse(num, out int result);
            if (success)
                array[i] = result;
            else
            {
                Console.WriteLine("Invalid index!");
                i--;
            }
        }
        Console.WriteLine();

        Console.WriteLine("Your array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}