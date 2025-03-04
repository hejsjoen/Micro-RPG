namespace RPG.Enemy.Enemies;

public class Bee : Enemy
{
    private bool _hasPoisionSting;

    public Bee(string name, int health, ConsoleColor color, bool hasPoisionSting) : base  (name, health, color,ArtAssets.Bee)
    {
        _hasPoisionSting = hasPoisionSting;
    }

    public void Fly()
    {
        Console.BackgroundColor = Color;
        Console.Write($" {Name} ");
        Console.ResetColor();
        Console.WriteLine(" takes the air!");
    }

    public void Sting()
    {
        Console.BackgroundColor = Color;
        Console.Write($" {Name} ");
        Console.ResetColor();
        Console.WriteLine(" lunges forward with their ");
        if (_hasPoisionSting) Console.WriteLine("poison stinger!");
        else Console.WriteLine("sharp sting!");
    }
}