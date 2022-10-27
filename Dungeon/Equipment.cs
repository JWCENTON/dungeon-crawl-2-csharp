using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    public class Equipment
    {
        private static readonly string _key = "K";
        private static readonly string _apple = "A";

        public static void CollectKey(Character character, string direction)
        {
            if (direction == _key)
            {
                character.Equipment.Add(_key);
            }
        }

        public static void CollectApple(Character character, string direction, Map map)
        {
            if (direction == _apple)
            {
                character.Equipment.Add(_apple);
            }
        }
    }
}
