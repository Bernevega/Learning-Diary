using System;
class Task7
{
    public static string TaskSeven(int age)
    {
        string ageName;

        if (age < 13 && age >= 0)
            ageName = "Child";
        else if (age >= 13 && age <= 17)
            ageName = "Teen";
        else if (age >= 18 && age <= 120)
            ageName = "Adult";
        else
            ageName = "Wrong Age";

        return ageName;
    }
}