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
            Equipment = new List<string>();
            EatApple();
        }

        public override void EatApple()
        {
            var fullHealth = 100;
            var applePower = 10;
            if (Health < fullHealth)
            {
                if (Equipment.Contains("A"))
                {
                    Health += applePower;
                    Equipment.Remove("A");
                }
            }
        }

    }
}
