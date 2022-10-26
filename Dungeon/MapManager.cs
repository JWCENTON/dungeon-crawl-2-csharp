using Dungeon.Enum;

namespace Dungeon
{
    internal class MapManager
    {
        public static void PutObjectOnMap(Map map, Character character)
        {
            map.FullMap[character.Position.x, character.Position.y] = new Square(Status.Player);
        }

        public static void TakeOffObjectFromMap(Map map, Character character)
        {
            map.FullMap[character.Position.x, character.Position.y] = new Square(Status.Empty);
        }
    }
}
