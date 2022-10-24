using Dungeon.Enum;

namespace Dungeon
{
    public class Display
    {
        public static void Map(Map map, Player player)
        {
            map.FullMap[player.position.x, player.position.y] = new Square(Status.Player);
            MapName(map);
            Console.WriteLine();
            for (int i = player.position.x - 5 ; i <= (player.position.x + 5); i++)
            {
                Console.WriteLine("\n");
                for (int j = player.position.y - 5; j <= (player.position.y + 5); j++)
                {
                    Console.Write(" ");
                    Console.Write($"\t{map.FullMap[i, j].GetStatus} ");
                }
            }
            Console.WriteLine("\n");
        }

        public static void MapName(Map map)
        {
            Console.WriteLine($"\tYou are in {map.Name} level");
        }
    }
}
