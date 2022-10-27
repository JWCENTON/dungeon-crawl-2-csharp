using Dungeon.Enum;

namespace Dungeon
{
    public class Player : Character
    {
        public Player()
        {
            Position = (21, 11); // 21, 11
            Name = "Alice";
            Health = 0;
            Type = Status.Player;
            Level = "Top floor";
            Equipment = new List<string>();
            EatApple();
        }

        public override void EatApple()
        {
            var fullHealth = 100;
            var applePower = 10;
            var apple = "A";
            if (Health < fullHealth)
            {
                if (Equipment.Contains(apple))
                {
                    Health += applePower;
                    Equipment.Remove(apple);
                }
            }
        }

    }
}
