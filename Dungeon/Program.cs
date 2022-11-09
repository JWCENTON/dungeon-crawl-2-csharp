using Dungeon.SqlManager;

namespace Dungeon
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var connection = new dungeonDbManager();

            Console.Read();
            Game game = new Game();
            game.Play();
        }
    }
}