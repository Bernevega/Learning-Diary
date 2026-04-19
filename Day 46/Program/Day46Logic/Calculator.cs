namespace Day46Logic
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        public string GetGrade(int score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
    }
}