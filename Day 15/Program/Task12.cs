using System;
using System.Collections.Generic;

class TextHelper
{
    public static void Shout(string text)
    {
        Console.WriteLine(text.ToUpper());
    }

}
class Task12
{
    public static void TaskTwelve()
    {
        TextHelper.Shout("hello!");

        Console.WriteLine();
    }
}