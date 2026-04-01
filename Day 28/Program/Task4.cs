using System;

enum EnemyState
{
    Idle,
    Chasing,
    Attacking
}

class Enemy
{
    public static void ShowEnemyState(EnemyState state)
    {
        switch (state)
        {
            case EnemyState.Idle:
                Console.WriteLine("The enemy is idle!");
                break;
            case EnemyState.Chasing:
                Console.WriteLine("The enemy is chasing you!");
                break;
            case EnemyState.Attacking:
                Console.WriteLine("The enemy is attacking you!");
                break;
        }
    }
}

class Task4
{
    public static void TaskFour()
    {
        Console.WriteLine("---Task 4---");

        EnemyState state1 = EnemyState.Idle;
        Enemy.ShowEnemyState(state1);
        state1 = EnemyState.Chasing;
        Enemy.ShowEnemyState(state1);
        state1 = EnemyState.Attacking;
        Enemy.ShowEnemyState(state1);

        Console.WriteLine();
    }
}