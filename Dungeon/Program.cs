using Dungeon.Monsters;
using Dungeon.SqlManager;

namespace Dungeon
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}