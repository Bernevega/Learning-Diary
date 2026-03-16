using System;
using System.Collections.Generic;

class Task2
{
    public static void TaskTwo()
    {
        Car car2 = new Car();
        car2.brand = "Toyota";
        car2.model = "Corolla";
        car2.year = 2018;

        Car car3 = new Car();
        car3.brand = "Ford";
        car3.model = "Explorer";
        car3.year = 2023;

        car2.PrintInfo();
        car3.PrintInfo();
    }
}

