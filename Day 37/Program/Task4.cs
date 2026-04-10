using System;

interface IMovable
{
    void Move();
}

interface IRechargeable
{
    void Recharge();
}

class Robot : IMovable, IRechargeable
{
    public void Move()
    {
        Console.WriteLine("The robot is moving!");
    }
    public void Recharge()
    {
        Console.WriteLine("The robot is recharging!");
    }
}
class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        IMovable movableRobot = new Robot();
        IRechargeable rechargeableRobot = new Robot();

        movableRobot.Move();
        rechargeableRobot.Recharge();

        Console.WriteLine();
    }
}