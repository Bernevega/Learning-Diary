using System;

class Task10
{
    public static string TaskTen(int temp)
    {
        string advice;

        if (temp < 0)
            advice = "Wear a winter jacket";
        else if (temp >= 0 && temp <= 15)
            advice = "Wear a coat";
        else if (temp >= 16 && temp <= 25)
            advice = "Light jacket is enough";
        else
            advice = "T-shirt weather";

        return advice;
    }
}