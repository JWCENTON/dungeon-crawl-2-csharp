using Dungeon.Enum;

namespace Dungeon.Monsters
{
    public class Wolf : Monster
    {
        public Wolf((int, int) startedPosition)
        {
            Position = startedPosition;
            Health = SetMonsterIntValue(21,29);
            AtackValue = SetMonsterIntValue(4, 8);
            TypeAtack = "Beat";
            this.Item = new Item("Claw");
            IsAlive = true;
            Type = Status.Monster1;
        }
    }
}
