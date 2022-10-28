using Dungeon.Enum;
using Dungeon.Maps;

namespace Dungeon
{
    public class Equipment
    {
        private static readonly string _key = "K";
        private static readonly string _apple = "A";
        
        private static void CollectKey(Character character, string direction)
        {
            if (direction == _key)
            {
                character.Equipment.Add(_key);
            }
        }

        private static void CollectApple(Character character, string direction, Map map)
        {
            if (direction == _apple)
            {
                character.Equipment.Add(_apple);
            }
        }

        public static void CollectItems(Character character, string direction, Map map)
        {
            CollectKey(character, direction);
            CollectApple(character, direction, map);
        }

        public static void ShowEquipment(Character player)
        {
            if (player.ShowEquipment == true)
            {
                Display.PlayerEquipment(player);
            }
        }
    }
}
