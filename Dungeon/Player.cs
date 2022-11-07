using Dungeon.Enum;

namespace Dungeon
{
    public class Alice : Character
    {
        public Alice()
        {
            Position = (49, 49); // 21, 11
            Name = "Alice";
            Health = 90; // 90
            AtackValue = 10;
            Type = Status.Player;
            Level = "Top floor";
            Equipment = new List<string>();
            ShowEquipment = false;
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
