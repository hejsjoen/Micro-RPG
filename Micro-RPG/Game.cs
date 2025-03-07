namespace Micro_RPG;

public class Game
{
    private readonly List<Character> Enemies;
    private Player _player;
    private List<Item> Items;

    public Game()
    {
        var leafNinjaStar = new Item("Leaf Ninja Star", 10);
        var fireAuntie = new Ant("Fire Auntie", 100, ConsoleColor.Red, 3);
        var hades = new Ant("Hades", 200, ConsoleColor.Blue, 6);
        var buzzBee = new Bee("Buzz Bee", 75, ConsoleColor.Yellow, false);
        Enemies = new List<Character> { fireAuntie, hades, buzzBee };
    }

    public void Run()
    {
        Console.WriteLine("Welcome to RPG!\n");
        _player = new Player("Kurt", 100, ConsoleColor.DarkCyan);
        _player.DisplayInfo();
        foreach (var enemy in Enemies) _player.Fight(enemy);
        /*if (enemy is Ant)
            {
                Ant ant = enemy as Ant;
                ant?.Defence();
                ant?.Fight();
            }
            else if (enemy is Bee)
            {
                Bee bee = enemy as Bee;
                bee.Fight();
                bee.Fight();
            }*/
        //WaitForKey();
    }

    private void WaitForKey()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
    }
}