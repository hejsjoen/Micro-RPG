namespace Micro_RPG;

public class Beetle : Character
{
    private readonly int _roll;

    public Beetle(string name, int health, ConsoleColor color, int roll) : base(name, health, color, ArtAssets.Beetle)
    {
        _roll = roll;
    }

    public void Roll()
    {
        Console.BackgroundColor = Color;
        Console.Write($" {Name} ");
        Console.ResetColor();
        Console.WriteLine($" rolls forward {_roll}");

        //if (CurrentItem != null) Console.Write($"They are carrying {CurrentItem.Name}\n");
    }

    public override void Fight(Character target)
    {
        void Fly()
        {
            Console.BackgroundColor = Color;
            Console.Write($" {Name} ");
            Console.ResetColor();
            Console.WriteLine(" flies!");
        }

        Fly();
    }
}