namespace Micro_RPG.Character;

public class Player : Enemy.Character
{
    public Player(string name, int health, ConsoleColor color) 
        : base(name, health, color, ArtAssets.Player)
    {
        
    }

    public override void Fight(Enemy.Character target)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine($"Player {Name} attacks {target.Name}.");
        Console.ResetColor();
    }
}