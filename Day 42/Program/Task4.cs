using System;

class Task4
{
    class InvalidScoreException : Exception
    {
        public InvalidScoreException(string message) : base(message) 
        { 
        }
    }

    public static void SetScore(int score)
    {
        if (score < 0)
            throw new InvalidScoreException("Score cannot be less than 0");

        Console.WriteLine($"The score is: {score}");
    }

    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        try
        {
            SetScore(100);
            SetScore(-10);
        }
        catch (InvalidScoreException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
    }
}