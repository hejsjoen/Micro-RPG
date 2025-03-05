using System.IO.MemoryMappedFiles;

namespace Micro_RPG.Enemy;

public class Enemy
{
    protected readonly int Health;
    protected readonly string Name;
    protected readonly string TextArt;
    protected readonly ConsoleColor Color;

    public Enemy(string name, int health, ConsoleColor color, string textArt)
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

    public virtual void Fight()
    {
        Console.WriteLine("Enemy is fighting...");
    }

    public virtual void Defence()
    {
        Console.WriteLine("Enemy is defending...");
    }
}