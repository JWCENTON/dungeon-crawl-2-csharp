using Dungeon.Maps;

namespace Dungeon
{
    public class Display
    {
        private static void PLayerHealthAndPosition(Character player)
        {
            string space = "     ";
            string lifeBar = new string('+', (player.Health / 10));

            Console.Write($"{space}{player.Name}: Health {lifeBar} (X: {player.Position.x}, Y: {player.Position.y}) ");
        }

        private static void PlayerEquipment(Character player)
        {
            Console.Write($"Equipment : ");
            foreach (var item in player.Equipment)
            {
                if (item == "K")
                {
                    Console.Write($"Key | ");
                }
            }
        }
        public static void Map(Map map, Character player)
        {
            string space = "     ";
            MapManager.PutObjectOnMap(map, player.Position, player.Type);
            MapName(map);
            Console.WriteLine();
            for (var i = player.Position.x - 10 ; i <= (player.Position.x + 10); i++)
            {

                Console.WriteLine("\n");
                for (var j = player.Position.y - 20; j <= (player.Position.y + 20); j++)
                {
                    if (j == player.Position.y - 20)
                    {
                        Console.Write(space);
                    }
                    Console.Write(" ");
                    Console.Write($"{map.FullMap[i, j].GetStatus}");
                }
            }
            MapManager.RemoveObjectFromMap(map, player.Position);

            Console.WriteLine("\n");
        }

        public static void MapName(Map map)
        {
            
            Console.WriteLine($"\t{map.Name}");
        }
        
        public static void DisplayPlayerDetails(Character player)
        {
            PLayerHealthAndPosition(player);
            PlayerEquipment(player);
        }

    }
}
