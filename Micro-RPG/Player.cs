namespace Micro_RPG;

public class Player : Character
{
    public Player(string name, int health, ConsoleColor color)
        : base(name, health, color, ArtAssets.Player)
    {
    }

    public override void Fight(Character target)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Player {Name} attacks {target.Name}.");
        Console.ResetColor();
    }
}