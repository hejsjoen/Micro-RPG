namespace Micro_RPG.Enemy;

public class Character
{
    public int Health { get; protected set; }
    public string Name { get; protected set; }
    public string TextArt { get; protected set; }
    public ConsoleColor Color { get; protected set; }
    public Random RandGen { get; protected set; }

    public Character(string name, int health, ConsoleColor color, string textArt)
    {
        Name = name;
        Health = health;
        Color = color;
        TextArt = textArt;
    }
    public void DisplayInfo()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"--- {Name} ---");
        Console.WriteLine($"\n{TextArt}\n");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"---");
        Console.ResetColor();
    }

    public virtual void Fight(Character target)
    {
        Console.WriteLine("Character is fighting...");
    }

    public virtual void Defence()
    {
        Console.WriteLine("Character is defending...");
    }
}