using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    internal class MapManager
    {
        public static void PutObjectOnMap(Map map, (int x,int y) coordinates, Status typeStatus)
        {
            int x = coordinates.x;
            int y = coordinates.y;

            map.FullMap[x, y] = new Square(typeStatus);
        }

        public static void TakeOffObjectFromMap(Map map, (int x, int y) coordinates)
        {
            int x = coordinates.x;
            int y = coordinates.y;
            map.FullMap[x, y] = new Square(Status.Empty);
        }
    }
}
