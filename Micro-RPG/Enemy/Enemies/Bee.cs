namespace Micro_RPG.Enemy.Enemies;

public class Bee : Enemy
{
    private bool _hasPoisionSting;

    public Bee(string name, int health, ConsoleColor color, bool hasPoisionSting) : base  (name, health, color,ArtAssets.Bee)
    {
        _hasPoisionSting = hasPoisionSting;
    }

    public override void Fight()
    {
        var rand = new Random();
        var i = rand.Next(10);
        if (i > 6)
        {
            Console.BackgroundColor = Color;
            Console.Write($" {Name} ");
            Console.ResetColor();
            Console.WriteLine(" takes the air!");
        }

        else
        {
            Console.BackgroundColor = Color;
            Console.Write($" {Name} ");
            Console.ResetColor();
            Console.Write(" lunges forward with their ");
            if (_hasPoisionSting) Console.WriteLine("poison stinger!");
            else Console.WriteLine("sharp sting!");
        }
    }
}