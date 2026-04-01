using System;

enum TrafficLight
{
    Red,
    Yellow,
    Green
}

class Light
{
    public static void PrintInfo(TrafficLight light)
    {
        if (light == TrafficLight.Red)
            Console.WriteLine("Stop");
        else if (light == TrafficLight.Yellow)
            Console.WriteLine("Get ready");
        else
            Console.WriteLine("Go");
    }
}

class Task2
{
    public static void TaskTwo()
    {
        Console.WriteLine("---Task 2---");

        TrafficLight light1 = TrafficLight.Red;
        Light.PrintInfo(light1);
        light1 = TrafficLight.Yellow;
        Light.PrintInfo(light1);
        light1 = TrafficLight.Green;
        Light.PrintInfo(light1);

        Console.WriteLine();
    }
}