namespace RPG;
public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Game game = new Game();
        game.Run();
    }
}