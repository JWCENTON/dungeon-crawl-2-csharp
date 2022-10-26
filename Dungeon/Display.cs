using System.Net.NetworkInformation;
using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    public class Display
    {
        public static void Map(Map map, Character player)
        {
            MapManager.PutObjectOnMap(map, player);
            MapName(map);
            Console.WriteLine();
            for (int i = player.Position.x - 10 ; i <= (player.Position.x + 10); i++)
            {
                Console.WriteLine("\n");
                for (int j = player.Position.y - 20; j <= (player.Position.y + 20); j++)
                {
                    Console.Write(" ");
                    Console.Write($"{map.FullMap[i, j].GetStatus}");
                }
            }
            MapManager.TakeOffObjectFromMap(map, player);

            Console.WriteLine("\n");
        }

        public static void MapName(Map map)
        {
            Console.WriteLine($"\t{map.Name}");
        }

        public static void PLayerPosition(Character player)
        {
            string lifeBar = new string('+', (player.Health / 10));
            Console.WriteLine($"{player.Name}: Health {lifeBar} (X: {player.Position.x}, Y: {player.Position.y})");
        }

    }
}
