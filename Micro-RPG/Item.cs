namespace Micro_RPG;

public class Item
{
    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public string Name { get; private set; }
    public int Quantity { get; private set; }
}