using System;
class Task2
{
    public static void AgeChecker(int age)
    {
        if (age is < 0)
        {
            Console.WriteLine("Invalid age");
            Console.WriteLine();
            return;
        }
        else if (age is < 13)
            Console.WriteLine("Child");
        else if (age is >= 13 and < 18)
            Console.WriteLine("Teen");
        else if (age is >= 18 and < 65)
            Console.WriteLine("Adult");
        else
            Console.WriteLine("Senior");

        if (age is not (>= 18 and < 65))
        {
            Console.WriteLine("Not an adult");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("An adult");
            Console.WriteLine();
        }
            
    }
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        AgeChecker(-10);
        AgeChecker(0);
        AgeChecker(5);
        AgeChecker(13);
        AgeChecker(18);
        AgeChecker(25);
        AgeChecker(55);
        AgeChecker(65);
        AgeChecker(85);
    }
}