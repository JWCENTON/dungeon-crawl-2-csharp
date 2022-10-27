namespace Dungeon
{
    public class Equipment
    {
        private static readonly string _key = "K";
        public static void CollectKey(Character character, string direction)
        {
            if (direction == _key)
            {
                character.Equipment.Add(_key);
            }
        }
    }
}
