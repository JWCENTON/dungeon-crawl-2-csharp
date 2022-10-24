using Dungeon.Enum;

namespace Dungeon
{
    public class Display
    {
        public static void Floor()
        {
            Player player = new Player();
            Map.FullMap[player.position.x, player.position.y] = new Square(Status.Player);
            Console.WriteLine("hello");
            for (int i = player.position.x - 5 ; i <= (player.position.x + 5); i++)
            {
                Console.WriteLine("\n");
                for (int j = player.position.y - 5; j <= (player.position.y + 5); j++)
                {
                    Console.Write(" ");
                    Console.Write($"\t{Map.FullMap[i, j].GetStatus} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
