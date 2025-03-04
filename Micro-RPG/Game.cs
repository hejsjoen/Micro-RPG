using RPG.Enemy.Enemies;
using RPG.Inventory;

namespace RPG;

public class Game
{
    private Ant FireAuntie;
    private Ant Hades;
    private Bee BuzzBee;
    private Item LeafNinjaStar;
    public Game()
    {
        LeafNinjaStar = new Item("Leaf Ninja Star", 10);
        
        FireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);
        Hades = new Ant("Hades", 200, ConsoleColor.Blue, 6);
        BuzzBee = new Bee("Buzz Bee", 75, ConsoleColor.Yellow, false);
    }

    public void Run()
    {
        Console.WriteLine("Welcome to RPG!");
        
        FireAuntie.DisplayInfo();
        Console.WriteLine();
        FireAuntie.Charge();
        FireAuntie.Bite();
        
        Hades.Pickup(LeafNinjaStar);
        Hades.DisplayInfo();
        Console.WriteLine();
        Hades.Charge();
        Hades.Bite();
        Console.WriteLine();
        
        BuzzBee.DisplayInfo();
        Console.WriteLine();
        BuzzBee.Fly();
        BuzzBee.Sting();
        Console.WriteLine();

        WaitForKey();
    }

    private void WaitForKey()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}