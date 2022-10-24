using Dungeon.Enum;

namespace Dungeon
{
    public class Display
    {
        public static void Map(Map map, Player player)
        {
            map.FullMap[player.Position.x, player.Position.y] = new Square(Status.Player);
            MapName(map);
            Console.WriteLine();
            for (int i = player.Position.x - 5 ; i <= (player.Position.x + 5); i++)
            {
                Console.WriteLine("\n");
                for (int j = player.Position.y - 5; j <= (player.Position.y + 5); j++)
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
