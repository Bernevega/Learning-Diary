using System;
interface IInteractable
{
    void Interact();
}

class Door : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("The door opens");
    }
}

class Chest : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("Yóu found gold in the chest");
    }
}

class NPC : IInteractable
{
    public void Interact()
    {
        Console.WriteLine("The NPC says hello");
    }
}

class Task5
{
    public static void TaskFive()
    {
        Console.WriteLine("---Task 5---");

        IInteractable door1 = new Door();
        IInteractable chest1 = new Chest();
        IInteractable NPC1 = new NPC();

        IInteractable[] items = new IInteractable[3];
        items[0] = door1;
        items[1] = chest1;
        items[2] = NPC1;

        foreach (IInteractable item in items)
        {
            item.Interact();
        }

        Console.WriteLine();
    }
}