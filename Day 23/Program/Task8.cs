using System;
using System.Collections.Generic;

class Character
{
    public string Name { get; set; }
    public int Level { get; set; }

    public static void PrintCharacter(Character character)
    {
        {
            if (character == null)
                Console.WriteLine("The character object does not exist yet.");
            else if (character.Name == null)
                Console.WriteLine("The character name does not exist yet.");
            else
                Console.WriteLine($"{character.Name}, {character.Level}.");
        }
    }
}

class Task8
{
    public static void TaskEight()
    {
        Console.WriteLine("--- Task 8 ---");

        Character char1 = new Character();
        Character char2 = new Character();
        char1.Name = "Warrior";
        char2.Name = null;
        char1.Level = 1;
        char2.Level = 1000;
        Character.PrintCharacter(char1);
        Character.PrintCharacter(char2);

        Console.WriteLine();
    }
}