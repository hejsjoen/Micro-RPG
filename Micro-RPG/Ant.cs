namespace Micro_RPG;

public class Ant : Character
{
    private readonly int _chargeDistance;
    private Item CurrentItem;

    public Ant(string name, int health, ConsoleColor color, int chargeDistance) : base(name, health, color,
        ArtAssets.Ant)
    {
        _chargeDistance = chargeDistance;
    }

    public void Pickup(Item item)
    {
        CurrentItem = item;
    }

    public override void Fight(Character target)
    {
        var rand = new Random();
        var i = rand.Next(10);
        if (i > 7)
        {
            Console.BackgroundColor = Color;
            Console.Write($" {Name} ");
            Console.ResetColor();
            Console.WriteLine($" charges swiftly forward {_chargeDistance}");

            if (CurrentItem != null) Console.Write($"They are carrying {CurrentItem.Name}\n");
        }

        else
        {
            Console.BackgroundColor = Color;
            Console.Write($" {Name} ");
            Console.ResetColor();
            Console.WriteLine(" viciously chomps down!");
        }
    }
}