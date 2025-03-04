using System.Data;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using RPG.Inventory;

namespace RPG.Enemy.Enemies;

public class Ant : Enemy
{
    private int _chargeDistance;
    private Item CurrentItem;
    public Ant(string name, int health, ConsoleColor color, int chargeDistance) : base(name, health, color, ArtAssets.Ant)
    {
        _chargeDistance = chargeDistance;
    }

    public void Pickup(Item item)
    {
        CurrentItem = item;
    }
    

    public void Charge()
    {
        Console.BackgroundColor = Color;
        Console.Write($" {Name} ");
        Console.ResetColor();
        Console.WriteLine($" charges swiftly forward {_chargeDistance}");

        if (CurrentItem != null) Console.Write($"They are carrying {CurrentItem.Name}\n");
    }

    public void Bite()
    {
        Console.BackgroundColor = Color;
        Console.Write($" {Name} ");
        Console.ResetColor();
        Console.WriteLine(" viciously chomps down!");
    }
}