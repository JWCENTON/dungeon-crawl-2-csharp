namespace Dungeon
{
    public class Equipment
    {
        public static void CollectKey(Character character, string direction)
        {
            if (direction == "K")
            {
                character.Equipment.Add("K");
            }
        }
    }
}
