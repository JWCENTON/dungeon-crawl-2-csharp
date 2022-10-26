using Dungeon.Enum;

namespace Dungeon
{
    public class Player : Character
    {
        public Player()
        {
            Position = (57, 48); // 21, 11
            Name = "Alice";
            Health = 100;
            Type = Status.Player;
            Level = "Top floor";
        }
    }
}
