using Dungeon.Enum;
using Dungeon.Maps;
using Dungeon.Monsters;

namespace Dungeon
{
    internal class MapManager
    {
        public static void PutObjectOnMap(Map map, (int y,int x) coordinates, Status typeStatus)
        {
            int x = coordinates.x;
            int y = coordinates.y;

            map.FullMap[x, y] = new Square(typeStatus);
        }

        public static void RemoveObjectFromMap(Map map, (int y, int x) coordinates)
        {
            int x = coordinates.x;
            int y = coordinates.y;

            map.FullMap[x, y] = new Square(Status.Empty);
        }

        public static void SetMonstersOnMap(Map map, List<Monster> Monsters)
        {
            foreach (var monster in Monsters)
            {
                PutObjectOnMap(map, monster.Position, monster.Type);
            }
        }

        public static void RemoveMonstersFromMap(Map map, List<Monster> Monsters)
        {
            foreach (var monster in Monsters)
            {
                RemoveObjectFromMap(map, monster.Position);
            }
        }
    }
}
